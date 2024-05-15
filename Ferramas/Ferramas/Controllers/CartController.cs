using Ferramas.Extensions;
using Ferramas.Model;
using Ferramas.Model.DataTransfer;
using Ferramas.Model.Domain;
using Ferramas.Model.ViewModels;
using MaiSchatz;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Ferramas.Controllers;

[Authorize]
public class CartController : BaseController
{
    private readonly FerraContext m_context;
    private readonly MeinMai m_exhangeApi;

    public CartController(FerraContext context, MeinMai exchangeApi)
    {
        m_context = context;
        m_exhangeApi = exchangeApi;
    }

    public async Task<IActionResult> Index()
    {
        CartProducts? cart = await GetCart();

        if (cart == null)
            return RedirectToAction("index", "home");

        KeyValuePair<bool, float> exchangeResult = await ExchangeRequest(m_exhangeApi);

        CartIndexViewModel model = await CartIndexViewModel.Create(cart, m_context, exchangeResult);

        return View(model);
    }

    public async Task<IActionResult> Add(string id)
    {
        CartProducts? cart = await GetCart();

        Guid productId = Guid.Parse(id);

        if(cart == null)
            cart = CartProducts.NewCart(Guid.NewGuid());

        HandleProductIncrement(ref cart, productId);

        Cart? updatedCart = await m_context
            .Cart
            .Where(c => c.Id == cart.CartId)
            .FirstOrDefaultAsync();

        if(updatedCart == null)
        {
            string userEmail = HttpContext.GetUserEmail();
            FerraUser user = await m_context
                .Users
                .FirstAsync(u => u.Email == userEmail);

            updatedCart = new()
            {
                Id = cart.CartId,
                UserId = user.Id,
                PurchasePending = true
            };
        }

        updatedCart.Details = cart.Serialize();

        await m_context
            .Cart
            .UpdateAsync(updatedCart);

        await m_context.SaveChangesAsync();

        return RedirectToAction("index");
    }

    [HttpPost]
    public async Task<IActionResult> Substract(string id)
    {
        CartProducts? cart = await GetCart();

        Guid productId = Guid.Parse(id);

        if (cart == null)
            return RedirectToAction("index");

        HandleProductDecrement(ref cart, productId);

        Cart updatedCart = await m_context
            .Cart
            .Where(c => c.Id == cart.CartId)
            .FirstAsync();

        updatedCart.Details = cart.Serialize();

        await m_context
            .Cart
            .UpdateAsync(updatedCart);

        await m_context.SaveChangesAsync();

        return RedirectToAction("index");
    }

    public async Task<IActionResult> Clear(string id)
    {
        Cart cart = await m_context
            .Cart
            .FirstAsync(c => c.Id == Guid.Parse(id));

        PurchaseAttempt[] attempts = await m_context
            .Purchases
            .Where(p => p.CartId == cart.Id)
            .ToArrayAsync();

        bool bought = false;

        foreach(PurchaseAttempt attempt in attempts)
        {
            if(attempt.Accepted)
            {
                bought = true;
                break;
            }    
        }    

        if (bought)
        {
            cart.PurchasePending = false;

            await m_context
                .Cart
                .UpdateAsync(cart);

            await m_context.SaveChangesAsync();

            return RedirectToAction("index", "home");
        }
        
        m_context
            .Purchases
            .DeleteRange(attempts);

        await m_context.SaveChangesAsync();

        m_context
            .Cart
            .Delete(cart);

        await m_context.SaveChangesAsync();

        return RedirectToAction("index", "home");
    }

    private async Task<CartProducts?> GetCart()
    {
        string userEmail = HttpContext.GetUserEmail();

        FerraUser? user = await m_context
            .Users
            .FirstOrDefaultAsync(u => u.Email == userEmail);

        if (user == null)
            return null;

        Cart? cart = await m_context
            .Cart
            .Where(c => c.UserId == user.Id && c.PurchasePending == true)
            .FirstOrDefaultAsync();

        CartProducts createCart()
        {
            if (cart == null)
                return CartProducts.Empty();

            if (CartProducts.TryDeserialize(cart.Details, out CartProducts result))
            {
                return result;
            }

            return CartProducts.Empty();
        }

        CartProducts cartDetails = createCart();

        return cartDetails;
    }

    private static void HandleProductIncrement(ref CartProducts cart, Guid productId)
    {
        if (cart.Products.ContainsKey(productId))
        {
            cart.Products[productId]++;
            return;
        }

        cart.Products
            .Add(productId, 1);
    }

    private static  void HandleProductDecrement(ref CartProducts cart, Guid productId)
    {
        if (cart.Products.ContainsKey(productId))
        {
            cart.Products[productId]--;

            if (cart.Products[productId] == 0)
                cart.Products.Remove(productId);
        }
    }
}
