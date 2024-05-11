using Ferramas.Model.Domain;

namespace Ferramas.Model.DataTransfer;

public sealed class JsonProduct
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public ImageBase64 Image { get; set; }
    public string Category { get; set; }
    public string Description { get; set; }
    public float PriceCLP { get; set; }
    public float PriceUSD { get; set; }
    public bool APIStatus { get; set; }

    private JsonProduct(Product product)
    {
        Id = product.Id;
        Name = product.Name;
        Category = product.Category.Name;
        Description = product.Description;
        PriceCLP = product.Price;
    }

    public static async Task<JsonProduct> Create(Product product, KeyValuePair<bool, float> requestResult)
    {
        JsonProduct result = new(product);
        result.Image = await HandleBase64Image(product.Image);
        result.APIStatus = requestResult.Key;
        result.PriceUSD = result.PriceCLP * requestResult.Value;

        return result;
    }

    private static async Task<ImageBase64> HandleBase64Image(string? image)
    {
        string handlePicture()
        {
            if (string.IsNullOrWhiteSpace(image))
                return "picture.png";
            return image;
        }

        string target = handlePicture();

        byte[] buffer = await File.ReadAllBytesAsync($"wwwroot/images/products/{target}");

        ImageBase64 imageBase64 = ImageBase64.PNG;
        imageBase64.Data = Convert.ToBase64String(buffer);

        return imageBase64;
    }
}
