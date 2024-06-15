using Ferramas.Extensions;
using Ferramas.Model;
using Ferramas.Model.DataTransfer;
using Ferramas.Model.Domain;
using Ferramas.Model.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Transbank.Common;
using Transbank.Webpay.Common;
using Transbank.Webpay.WebpayPlus;
using Transbank.Webpay.WebpayPlus.Responses;

namespace Ferramas.Controllers;

[Authorize]
public sealed class PurchaseController : BaseController
{
    // ref: https://www.transbankdevelopers.cl/referencia/webpay#crear-una-transaccion

    private readonly FerraContext m_context;

    public PurchaseController(FerraContext context)
    {
        m_context = context;
    }

    public async Task<IActionResult> PurchaseProduct(string id)
    {
        Guid productId = Guid.Parse(id);

        string userMail = HttpContext.GetUserEmail();
        FerraUser user = await m_context
            .Users
            .FirstAsync(u => u.Email == userMail);

        Cart cart = new()
        {
            Id = Guid.NewGuid(),
            UserId = user.Id,
            PurchasePending = true
        };

        CartProducts details = CartProducts.NewCart(cart.Id);
        details.Products.Add(productId, 1);

        cart.Details = details.Serialize();

        await m_context
            .Cart
            .InsertAsync(cart);

        await m_context.SaveChangesAsync();

        PurchaseAttempt purchase = await CreatePurchase(details);

        CreateResponse response = Transaction(purchase);

        PurchasePayViewModel model = new()
        {
            Token = response.Token,
            Url = response.Url
        };

        return View("Pay", model);
    }

    public async Task<IActionResult> PurchaseCart(string id)
    {
        Guid cartId = Guid.Parse(id);
        
        Cart? cart = await m_context
            .Cart
            .FirstOrDefaultAsync(cart => cart.Id == cartId);

        if(cart == null)
        {
            return RedirectToAction("index", "home");
        }

        if(CartProducts.TryDeserialize(cart.Details, out CartProducts details))
        {
            PurchaseAttempt purchase = await CreatePurchase(details);

            CreateResponse response = Transaction(purchase);

            PurchasePayViewModel model = new()
            {
                Token = response.Token,
                Url = response.Url
            };

            return View("Pay", model);
        }

        return RedirectToAction("index", "home");
    }

    public async Task<IActionResult> ConfirmTransaction(string token_ws)
    {
        Options transOptions = new(IntegrationCommerceCodes.WEBPAY_PLUS, IntegrationApiKeys.WEBPAY, WebpayIntegrationType.Test);
        Transaction tx = new(transOptions);

        CommitResponse response = tx.Commit(token_ws);

        PurchaseConfirmViewModel model = new(response);

        if (model.Success)
        {
            PurchaseAttempt attempt = await m_context 
                .Purchases
                .FirstAsync(a => a.Id == Guid.Parse(response.SessionId));

            attempt.Accepted = true;

            await m_context
                .Purchases
                .UpdateAsync(attempt);

            Cart cart = await m_context
                .Cart
                .FirstAsync(c => c.Id == attempt.CartId);

            cart.PurchasePending = false;

            await m_context
                .Cart
                .UpdateAsync(cart);

            await m_context.SaveChangesAsync();
        }

        return View(model);
    }

    private CreateResponse Transaction(PurchaseAttempt attempt)
    {
        Options transOptions = new(IntegrationCommerceCodes.WEBPAY_PLUS, IntegrationApiKeys.WEBPAY, WebpayIntegrationType.Test);
        Transaction tx = new(transOptions);

        string url = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host}/purchase/confirmTransaction/";

        CreateResponse response = tx.Create(attempt.TransbankSession, attempt.Id.ToString(), (decimal)attempt.PurchasePrice, url);

        return response;
    }

    private async Task<PurchaseAttempt> CreatePurchase(CartProducts details)
    {
        Guid[] productIds = details
                .Products
                .Select(k => k.Key)
                .ToArray();

        Product[] products = await m_context
            .Products
            .Where(p => productIds.Contains(p.Id))
            .ToArrayAsync();

        float totalPrice = 0f;

        foreach (KeyValuePair<Guid, int> kvp in details.Products)
        {
            float unitPrice = products
                .First(p => p.Id == kvp.Key)
                .Price;

            totalPrice += kvp.Value * unitPrice;
        }

        int purchasesCount = await m_context
            .Purchases
            .CountAsync();

        string buyOrder = $"FerraMasASY20224{purchasesCount + 1}";

        PurchaseAttempt purchase = new()
        {
            Id = Guid.NewGuid(),
            CartId = details.CartId,
            TransbankSession = buyOrder,
            PurchasePrice = totalPrice,
            AttemptDate = DateTime.Now,
            Accepted = false
        };

        await m_context
            .Purchases
            .InsertAsync(purchase);

        await m_context.SaveChangesAsync();

        return purchase;
    }
}
