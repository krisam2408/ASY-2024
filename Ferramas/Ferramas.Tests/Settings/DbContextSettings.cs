using Ferramas.Extensions;
using Ferramas.Model;
using Microsoft.EntityFrameworkCore;

namespace Ferramas.Tests.Settings
{
    public static class DbContextSettings
    {
        public static FerraContext CreateMockContext()
        {
            DbContextOptions<FerraContext> options = new DbContextOptionsBuilder<FerraContext>()
                .UseInMemoryDatabase("FerraMock")
                .Options;
            
            using(FerraContext context = new(options))
            {
                context
                    .Users
                    .InsertRangeAsync(MockExtension.GetUsers());

                context
                    .Categories
                    .InsertRangeAsync(MockExtension.GetCategories());

                context
                    .Products
                    .InsertRangeAsync(MockExtension.GetProducts());

                context.SaveChanges();
            }

            return new(options);
        }
    }
}
