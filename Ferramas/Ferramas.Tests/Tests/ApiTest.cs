using Ferramas.Controllers;
using Ferramas.Model.DataTransfer;
using Ferramas.Tests.Settings;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace Ferramas.Tests.Tests
{
    public class ApiTest
    {
        [Fact]
        public async Task GetProducts()
        {
            Mock<IFerraDb> mockContext = DbContextSettings.CreateMockContext();
            ProductController controller = new(mockContext.Object, null);

            IActionResult result = await controller.Products();

            Assert
                .True(result is JsonResult);
        }
    }
}