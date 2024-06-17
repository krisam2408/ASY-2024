using Ferramas.Controllers;
using Ferramas.Extensions;
using Ferramas.Model;
using Ferramas.Model.DataTransfer;
using Ferramas.Model.Domain;
using Ferramas.Model.ViewModels;
using Ferramas.Tests.Settings;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Xunit.Abstractions;

namespace Ferramas.Tests.Tests;

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
    #endregion
}