using Ferramas.Model.Domain;
using Microsoft.EntityFrameworkCore;

namespace Ferramas.Model.DataTransfer
{
    public interface IFerraDb
    {
        public DbSet<Cart> Cart { get; }
        public DbSet<Category> Categories { get; }
        public DbSet<FerraUser> Users { get; }
        public DbSet<Product> Products { get; }
        public DbSet<PurchaseAttempt> Purchases { get; }
        public DbSet<Subscription> Subscriptions { get; }

        public Task SaveChangesAsync();
    }
}
