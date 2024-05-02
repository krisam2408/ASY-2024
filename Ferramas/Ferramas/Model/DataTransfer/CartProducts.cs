using Ferramas.Model.Domain;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Ferramas.Model.DataTransfer;

public sealed class CartProducts
{
    public Guid CartId { get; set; }
    public Dictionary<Guid, int> Products { get; set; }

    private CartProducts() 
    {
        Products = new();
    }

    public static CartProducts NewCart(Guid cartId)
    {
        CartProducts result = new()
        {
            CartId = cartId
        };
        return result;
    }

    public static bool TryDeserialize(string json, out CartProducts cart)
    {
        CartProducts? result = JsonConvert.DeserializeObject<CartProducts>(json);

        if(result == null)
        {
            cart = NewCart(Guid.NewGuid());
            return false;
        }

        cart = result;
        return true;
    }

    public string Serialize()
    {
        return JsonConvert.SerializeObject(this);
    }

    public async Task<float> TotalValue(FerraContext context)
    {
        float result = 0f;

        foreach(KeyValuePair<Guid, int> kv in Products)
        {
            Product product = await context
                .Products
                .FirstAsync(p => p.Id == kv.Key);

            float itemPrice = product.Price * kv.Value;
            result += itemPrice;
        }

        return result;
    }
}
