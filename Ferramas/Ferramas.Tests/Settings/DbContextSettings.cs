using Ferramas.Extensions;
using Ferramas.Model.DataTransfer;
using Moq;

namespace Ferramas.Tests.Settings
{
    public static class DbContextSettings
    {
        public static Mock<IFerraDb> CreateMockContext()
        {
            Mock<IFerraDb> result = new Mock<IFerraDb>();
            result.Setup(db => db.Users)
                .Returns(() => MockExtension.GetUsers());
            result.Setup(db => db.Categories)
                .Returns(() => MockExtension.GetCategories());
            result.Setup(db => db.Products)
                .Returns(() => MockExtension.GetProducts());
            result.Setup(db => db.Subscriptions)
                .Returns(() => MockExtension.GetUsers()[0]);

            return result;
        }
    }
}
