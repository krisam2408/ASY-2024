using Ferramas.Model.Domain;
using MaiSchatz;

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

    private readonly string? m_image;

    public JsonProduct(Product product)
    {
        Id = product.Id;
        Name = product.Name;
        m_image = product.Image;
        Category = product.Category.Name;
        Description = product.Description;
        PriceCLP = product.Price;
    }

    public async Task Initialize(MeinMai caller)
    {
        Image = await HandleBase64Image(m_image);

        float usdFactor = await HandleUSDPrice(caller);
        PriceUSD = PriceCLP * usdFactor;
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

    private static async Task<float> HandleUSDPrice(MeinMai caller)
    {
        ExchangeResponse? response = await caller
            .CallAsync<ExchangeResponse>();

        if (response == null)
            return 0f;

        if (!response.Success)
            return 0f;
        
        float clp = response.Rates["CLP"];
        float usd = response.Rates["USD"];

        float factor = usd / clp;

        return factor;
    }
}
