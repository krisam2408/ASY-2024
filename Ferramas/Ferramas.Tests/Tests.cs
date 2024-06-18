using Ferramas.Controllers;
using Ferramas.Extensions;
using Ferramas.Model;
using Ferramas.Model.DataTransfer;
using Ferramas.Model.Domain;
using Ferramas.Model.ViewModels;
using Ferramas.Tests.Settings;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Xunit.Abstractions;

namespace Ferramas.Tests;

public class Tests
{
    private readonly ITestOutputHelper m_output;
    private readonly FerraContext m_context;
    private readonly MockMeinMai m_exchangeApi;

    public Tests(ITestOutputHelper output)
    {
        m_output = output;
        m_context = MockDbContext.CreateMockContext();
        m_exchangeApi = new();
    }

    private enum Scenario
    {
        NoDiscount = 4,
        Discounted = 8
    }

    #region Api
    [Fact]
    public async Task API_GetProducts()
    {
        ProductController controller = new(m_context, m_exchangeApi, true);

        IActionResult result = await controller.Products();

        bool assertProducts()
        {
            if (result is JsonResult json && json.Value != null)
            {
                List<JsonProduct> value = (List<JsonProduct>)json.Value;

                if (value.Count > 0)
                {
                    m_output.WriteLine($"Count: {value.Count}");
                    foreach (JsonProduct product in value)
                        m_output.WriteLine($"- {product.Name}");

                    return true;
                }
            }

            return false;
        }

        Assert.True(assertProducts());
    }

    [Theory]
    [InlineData("DecoHogar")]
    [InlineData("Tecnología")]
    [InlineData("Moda")]
    public async Task API_GetProductsInCategory(string value)
    {
        ProductController controller = new(m_context, m_exchangeApi, true);

        IActionResult result = await controller.ListByCategory(value);

        bool assertProducts()
        {
            if (result is JsonResult json && json.Value != null)
            {
                List<JsonProduct> value = (List<JsonProduct>)json.Value;

                if (value.Count > 0)
                {
                    m_output.WriteLine($"Count: {value.Count}");
                    foreach (JsonProduct product in value)
                        m_output.WriteLine($"- {product.Name}");

                    return true;
                }
            }

            return false;
        }

        Assert.True(assertProducts());
    }

    [Theory]
    [InlineData("6c056e3a-6963-4c42-abaa-a19896106f9d")]
    [InlineData("7cd5b969-f71e-40c5-9512-9ff63c6fdbf6")]
    [InlineData("9a153313-76f7-410f-a5ac-c18a7ec614a5")]
    public async Task API_GetProductById(string value)
    {
        ProductController controller = new(m_context, m_exchangeApi, true);

        IActionResult result = await controller.ProductById(value);

        bool assertProducts()
        {
            if (result is JsonResult json && json.Value != null)
            {
                JsonProduct value = (JsonProduct)json.Value;

                m_output.WriteLine($"Product: {value.Name}");

                return true;
            }

            return false;
        }

        Assert.True(assertProducts());
    }
    #endregion

    #region User
    [Fact]
    public async Task User_SubscribeUser()
    {
        HomeController controller = new(m_context, true);

        IActionResult result = await controller.Subscribe("pe.palo@gmail.com");

        async Task<bool> assertResult()
        {
            if (result is ViewResult view)
            {
                return false;
            }

            if (result is RedirectToActionResult redirect)
            {
                Subscription? user = await m_context
                    .Subscriptions
                    .FirstOrDefaultAsync(s => s.Email == "pe.palo@gmail.com");

                return user != null;
            }

            return false;
        }

        Assert.True(await assertResult());
    }

    [Theory]
    [InlineData("admin", true)]
    [InlineData("admin1", false)]
    public async Task User_Login(string pass, bool expected)
    {
        AuthController controller = new(m_context, true);
        
        AuthLoginViewModel model = new()
        {
            Email = "testerina@gmail.com",
            Password = pass
        };

        IActionResult result = await controller.Login(model);
        
        bool assertResut()
        {
            m_output.WriteLine($"Login result expected: {expected}");
            if (result is RedirectToActionResult redirect)
            {
                if (redirect.ControllerName == "home")
                    return true;
            }

            return false;
        };

        Assert.True(assertResut() == expected);
    }

    [Fact]
    public async Task User_Logout()
    {
        AuthController controller = new(m_context, true);

        IActionResult result = await controller.Logout();

        bool assertResult()
        {
            if(result is RedirectToActionResult redirect)
            {
                if(redirect.ControllerName == "home" && redirect.ActionName == "index")
                    return true;
            }

            return false;
        }

        Assert.True(assertResult());
    }
    #endregion

    #region Cart
    [Fact]
    public async Task Cart_BuyProduct()
    {
        const string productId = "6c056e3a-6963-4c42-abaa-a19896106f9d";

        PurchaseController controller = new(m_context, true);

        IActionResult result = await controller.PurchaseProduct(productId);

        bool assertResult()
        {
            if(result is ViewResult view && view.Model != null)
            {
                PurchasePayViewModel model = (PurchasePayViewModel)view.Model;

                // https://webpay3gint.transbank.cl/webpayserver/initTransaction

                m_output.WriteLine(model.Url);

                bool webpay = model.Url.Contains("webpay");
                bool endpoint = model.Url.Contains("/initTransaction");
                bool token = !string.IsNullOrWhiteSpace(model.Token);

                return webpay && endpoint && token;
            }

            return false;
        }

        Assert.True(assertResult());
    }

    [Fact]
    public async Task Cart_AddToCart()
    {
        const string productId = "6c056e3a-6963-4c42-abaa-a19896106f9d";

        CartController controller = new(m_context, m_exchangeApi, true);

        await controller.Add(productId);

        IActionResult result = await controller.Index();

        bool assertResult()
        {
            if(result is ViewResult view && view.Model != null)
            {
                CartIndexViewModel model = (CartIndexViewModel) view.Model;
                if(model.JsonCart.Count > 0)
                {
                    foreach(KeyValuePair<JsonProduct, int> details in model.JsonCart)
                    {
                        if (details.Key.Id.ToString() == productId)
                            return true;
                    }
                }
            }

            return false;
        }

        Assert.True(assertResult());
    }

    [Fact]
    public async Task Cart_ViewCart()
    {
        CartController controller = new(m_context, m_exchangeApi, true);

        await ClearCarts(controller);
        Guid[] productIds = await AddMultipleItemsToCart(controller, Scenario.NoDiscount);

        IActionResult result = await controller.Index();

        bool assertResult()
        {
            if (result is ViewResult view && view.Model != null)
            {
                CartIndexViewModel model = (CartIndexViewModel)view.Model;

                bool rightProducts = true;

                int count = 0;

                foreach(KeyValuePair<JsonProduct, int> product in model.JsonCart)
                {
                    count += product.Value;

                    if(!productIds.Contains(product.Key.Id))
                        rightProducts = false;
                }

                bool rightCount = count == productIds.Length;

                m_output.WriteLine($"Right Products: {rightProducts}\nExpected Products: {count} / {productIds.Length}");

                return rightProducts && rightCount;
            }

            return false;
        }

        Assert.True(assertResult());
    }

    [Fact]
    public async Task Cart_SumPrices()
    {
        CartController controller = new(m_context, m_exchangeApi, true);

        await ClearCarts(controller);
        await AddMultipleItemsToCart(controller, Scenario.NoDiscount);

        IActionResult result = await controller.Index();

        bool assertResult()
        {
            if (result is ViewResult view && view.Model != null)
            {
                CartIndexViewModel model = (CartIndexViewModel)view.Model;

                float price = 0f;

                foreach (KeyValuePair<JsonProduct, int> product in model.JsonCart)
                {
                    price += product.Key.PriceCLP * product.Value;
                }

                bool rightPrice = price == model.CLPTotalValue;

                m_output.WriteLine($"Expected Price: {price}\nReceived Price: {model.CLPTotalValue}");

                return rightPrice;
            }

            return false;
        }

        Assert.True(assertResult());
    }

    [Fact]
    public async Task Cart_SumPricesWithDiscount()
    {
        HomeController homeController = new(m_context, true);

        await homeController.Subscribe("testerina@gmail.com");

        CartController cartController = new(m_context, m_exchangeApi, true);

        await ClearCarts(cartController);
        await AddMultipleItemsToCart(cartController, Scenario.Discounted);

        IActionResult result = await cartController.Index();

        bool assertResult()
        {
            if (result is ViewResult view && view.Model != null)
            {
                CartIndexViewModel model = (CartIndexViewModel)view.Model;

                bool appliesDiscount = model.ApplyDiscount;

                float normalPrice = 0f;
                float discountedPrice = 0f;

                foreach (KeyValuePair<JsonProduct, int> product in model.JsonCart)
                {
                    normalPrice += product.Key.PriceCLP * product.Value;
                    discountedPrice += product.Key.PriceCLP * product.Value;
                }

                discountedPrice *= 0.9f;

                bool rightModelPrice = discountedPrice == model.CLPTotalValue;
                bool rightDiscountedPrice = model.CLPTotalValue == normalPrice * 0.9f;

                m_output.WriteLine($"Normal Price: {normalPrice}\nExpected Price: {discountedPrice}\nReceived Price: {model.CLPTotalValue}");

                return appliesDiscount && rightModelPrice && rightDiscountedPrice;
            }

            return false;
        }

        Assert.True(assertResult());
    }

    private static async Task<Guid[]> AddMultipleItemsToCart(CartController controller, Scenario scenario)
    {
        string[] productIds =
        [
            "cff8d445-fcd6-4a47-a657-df677546962b",
            "cff8d445-fcd6-4a47-a657-df677546962b",
            "a255e5fa-a1ce-491c-927b-81ec0c7040e5",
            "4a9af2b6-5527-4649-80df-b27fc4cad78e",
            "c0622cdb-6902-4ae5-a973-e0835031d801",
            "c0622cdb-6902-4ae5-a973-e0835031d801",
            "c0622cdb-6902-4ae5-a973-e0835031d801",
            "c0622cdb-6902-4ae5-a973-e0835031d801",
        ];

        List<Guid> result = new();

        int len = (int)scenario;
        for(int i = 0; i < len; i++)
        {
            string id = productIds[i];
            result.Add(Guid.Parse(id));
            await controller.Add(id);
        }

        return result
            .ToArray();
    }

    private async Task ClearCarts(CartController controller)
    {
        string[] cartIds = await m_context
            .Cart
            .Select(c => c.Id.ToString())
            .ToArrayAsync();

        foreach (string cartId in cartIds)
        {
            await controller.Clear(cartId);
        }
    }
    #endregion
}