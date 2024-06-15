using Ferramas.Extensions;
using Ferramas.Model.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Ferramas.Model;

public sealed class FerraContext : DbContext
{
    public FerraContext(DbContextOptions<FerraContext> options) : base(options) { }

    public DbSet<Cart> Cart { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<FerraUser> Users { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<PurchaseAttempt> Purchases { get; set; }
    public DbSet<Subscription> Subscriptions { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        Keys(modelBuilder);
        Seed(modelBuilder);
    }

    private static void Keys(ModelBuilder builder)
    {
        IEnumerable<IMutableForeignKey> foreignKeys = builder
            .Model
            .GetEntityTypes()
            .SelectMany(k => k.GetForeignKeys());

        foreach (IMutableForeignKey key in foreignKeys)
            key.DeleteBehavior = DeleteBehavior.NoAction;

        builder.Entity<Subscription>()
            .HasIndex(k => k.Email)
            .IsUnique();
    }

    private static void Seed(ModelBuilder builder)
    {
        FerraUser[] users = MockExtension.GetUsers();
        
        builder.Entity<FerraUser>()
            .HasData(users);

        Category[] categories = MockExtension.GetCategories();
        
        builder.Entity<Category>()
            .HasData(categories);

        Product[] products = MockExtension.GetProducts();
        
        builder.Entity<Product>()
            .HasData(products);
    }

    public async Task SaveChangesAsync()
    {
        await base.SaveChangesAsync();
    }
}
