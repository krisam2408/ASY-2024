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

    private readonly bool m_isMocked;

    private JsonProduct(Product product, bool isMocked)
    {
        Id = product.Id;
        Name = product.Name;
        Category = product.Category.Name;
        Description = product.Description;
        PriceCLP = product.Price;
        m_isMocked = isMocked;
    }

    public static async Task<JsonProduct> Create(Product product, KeyValuePair<bool, float> requestResult, bool isMocked)
    {
        JsonProduct result = new(product, isMocked);
        result.Image = await result.HandleBase64Image(product.Image);
        result.APIStatus = requestResult.Key;
        result.PriceUSD = result.PriceCLP * requestResult.Value;

        return result;
    }

    private async Task<ImageBase64> HandleBase64Image(string? image)
    {
        string handlePicture()
        {
            if (string.IsNullOrWhiteSpace(image))
                return "picture.png";
            return image;
        }

        string target = handlePicture();

        ImageBase64 imageBase64 = ImageBase64.PNG;

        if (!m_isMocked)
        {
            byte[] buffer = await File.ReadAllBytesAsync($"wwwroot/images/products/{target}");
            imageBase64.Data = Convert.ToBase64String(buffer);
            return imageBase64;
        }
        
        imageBase64.Data = $"404 - Image {target} not found";
        return imageBase64;
    }
}
