using Ferramas.Extensions;
using Ferramas.Model;
using Ferramas.Model.Domain;
using Microsoft.EntityFrameworkCore;

namespace Ferramas.Tests.Settings;

public static class MockDbContext
{
    public static FerraContext CreateMockContext()
    {
        DbContextOptions<FerraContext> options = new DbContextOptionsBuilder<FerraContext>()
            .UseInMemoryDatabase("FerraMock")
            .Options;
        
        using(FerraContext context = new(options))
        {
            foreach (FerraUser user in MockExtension.GetUsers())
            {
                FerraUser? old = context
                    .Users
                    .FirstOrDefault(u => u.Id == user.Id);

                if(old == null)
                    context.Users.Add(user);
            }
            
            foreach(Category category in MockExtension.GetCategories())
            {
                Category? old = context
                    .Categories
                    .FirstOrDefault(u => u.Id == category.Id);

                if(old == null) 
                    context.Categories.Add(category);
            }

            foreach (Product product in MockExtension.GetProducts())
            {
                Product? old = context
                    .Products
                    .FirstOrDefault(u => u.Id == product.Id);

                if(old == null)
                    context.Products.Add(product);
            }

            context.SaveChanges();
        }

        return new(options);
    }
}
