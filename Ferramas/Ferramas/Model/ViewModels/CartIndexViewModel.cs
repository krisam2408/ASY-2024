using Ferramas.Model.DataTransfer;
using Ferramas.Model.Domain;
using Microsoft.EntityFrameworkCore;

namespace Ferramas.Model.ViewModels;

public class CartIndexViewModel
{
    public Guid? CartId { get; set; }
    public bool GotProducts { get; set; }
    public Dictionary<JsonProduct, int> JsonCart { get; set; }
    public float CLPTotalValue { get; set; }
    public float USDTotalValue { get; set; }
    public bool ApplyDiscount { get; set; }
    public bool APIStatus { get; set; }

    private CartIndexViewModel(CartProducts cart)
    {
        CartId = cart.CartId;
        JsonCart = new();
        CLPTotalValue = 0f;
        USDTotalValue = 0f;

        if(cart.Products.Count == 0)
        {
            GotProducts = false;
            return;
        }

        GotProducts = true;
    }

    public static async Task<CartIndexViewModel> Create(CartProducts cart, FerraContext context, KeyValuePair<bool, float> requestResult)
    {
        CartIndexViewModel result = new(cart);
        result.APIStatus = requestResult.Key;

        if (cart.SubscribedUser && cart.Products.Count >= 4)
            result.ApplyDiscount = true;

        foreach(KeyValuePair<Guid, int> kv in cart.Products)
        {
            Product? product = await context
                .Products
                .Include(p => p.Category)
                .FirstOrDefaultAsync(p => p.Id == kv.Key);

            if (product == null)
                continue;

            JsonProduct jsonProduct = await JsonProduct.Create(product, requestResult);

            result.CLPTotalValue += jsonProduct.PriceCLP * kv.Value;
            result.USDTotalValue += jsonProduct.PriceUSD * kv.Value;

            result.JsonCart
                .TryAdd(jsonProduct, kv.Value);
        }

        if(result.ApplyDiscount)
        {
            result.CLPTotalValue *= 0.9f;
            result.USDTotalValue *= 0.9f;
        }

        return result;
    }
}
