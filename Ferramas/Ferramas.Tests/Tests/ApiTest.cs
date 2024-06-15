using Ferramas.Controllers;
using Ferramas.Extensions;
using Ferramas.Model;
using Ferramas.Model.DataTransfer;
using Ferramas.Tests.Settings;
using Microsoft.AspNetCore.Mvc;
using Xunit.Abstractions;

namespace Ferramas.Tests.Tests;

public class ApiTest
{
    private readonly ITestOutputHelper m_output;
    private readonly FerraContext m_context;

    public ApiTest(ITestOutputHelper output)
    {
        m_output = output;
        m_context = DbContextSettings.CreateMockContext();
    }

    [Fact]
    public async Task GetProducts()
    {
        ProductController controller = new(m_context, null);

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
    public async Task GetProductsInCategory(string value)
    {
        ProductController controller = new(m_context, null);

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
    public async Task GetProductById(string value)
    {
        ProductController controller = new(m_context, null);

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
}