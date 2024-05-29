using Newtonsoft.Json;

namespace Ferramas.Model.DataTransfer;

public sealed class CartProducts
{
    public Guid CartId { get; set; }
    public Dictionary<Guid, int> Products { get; set; }
    public bool SubscribedUser { get; set; }

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

    public static CartProducts Empty()
    {
        return new()
        {
            CartId = Guid.NewGuid()
        };
    }

    public static bool TryDeserialize(string json, out CartProducts cart)
    {
        CartProducts? result = JsonConvert.DeserializeObject<CartProducts>(json);

        if(result == null)
        {
            cart = Empty();
            return false;
        }

        cart = result;
        return true;
    }

    public string Serialize()
    {
        return JsonConvert.SerializeObject(this);
    }
}
