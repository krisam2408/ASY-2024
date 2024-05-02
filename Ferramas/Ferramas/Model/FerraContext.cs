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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        Keys(modelBuilder);
        Seed(modelBuilder);
    }

    public enum ProductCategories
    {
        Cocina = 1,
        DecoHogar,
        Pasatiempos,
        Teconologia,
        Construccion,
        Moda
    }

    private static void Keys(ModelBuilder builder)
    {
        IEnumerable<IMutableForeignKey> foreignKeys = builder
            .Model
            .GetEntityTypes()
            .SelectMany(k => k.GetForeignKeys());

        foreach (IMutableForeignKey key in foreignKeys)
            key.DeleteBehavior = DeleteBehavior.NoAction;
    }

    private static void Seed(ModelBuilder builder)
    {
        FerraUser[] users =
        [
            new() { Id = Guid.NewGuid(), Name="Testerina", Surname="Tester", Email = "testerina@gmail.com", PasswordHash = "admin" },
            new() { Id = Guid.NewGuid(), Name="Armando", Surname="Casas", Email = "acasas@gmail.com", PasswordHash = "admin" },
            new() { Id = Guid.NewGuid(), Name="Pedro", Surname="Palote", Email = "pe.palo@gmail.com", PasswordHash = "admin" },
        ];

        builder.Entity<FerraUser>()
            .HasData(users);

        Category[] categories =
        [
            new() { Id = (int) ProductCategories.Cocina, Name = "Comestibles / Cocina" },
            new() { Id = (int) ProductCategories.DecoHogar, Name = "DecoHogar" },
            new() { Id = (int) ProductCategories.Pasatiempos, Name = "Pasatiempos" },
            new() { Id = (int) ProductCategories.Teconologia, Name = "Tecnología" },
            new() { Id = (int) ProductCategories.Construccion, Name = "Construcción" },
            new() { Id = (int) ProductCategories.Moda, Name = "Moda" },
        ];

        builder.Entity<Category>()
            .HasData(categories);

        Product[] cocinaProducts = 
        [
            new() { Id = Guid.NewGuid(), CategoryId = (int) ProductCategories.Cocina, Name = "Aceite en Polvo", Description = "Para hacerte el hipster y decir que cocinas todo con agua.", Price = 6500 },
        ];

        Product[] decoProducts = 
        [
            new() { Id = Guid.NewGuid(), CategoryId = (int) ProductCategories.DecoHogar, Name = "Látigo con Puntas de Cobre", Description = "Para demostrarle a Dios que eres impuro pero cuidas de tu salud.", Price = 13250 },
            new() { Id = Guid.NewGuid(), CategoryId = (int) ProductCategories.DecoHogar, Name = "Figura de Fierro de Don Quijote", Description = "Sancho Panza Metálico.", Price = 23250 },
        ];

        Product[] pasatiemposProducts = 
        [
            new() { Id = Guid.NewGuid(), CategoryId = (int) ProductCategories.Pasatiempos, Name = "Látigo con Puntas Sin Filo", Description = "Para disfrazarte de alguien que se cree impuro.", Price = 10250 },
        ];

        Product[] tecnologiaProducts = 
        [
            new() { Id = Guid.NewGuid(), CategoryId = (int) ProductCategories.Teconologia, Name = "Multiantena de Fierro", Description = "Para escuchar ese zumbido que molesta a tus vecinos y ver los canales que no te gustan.", Price = 6350 },
        ];

        Product[] construccionProducts = 
        [
            new() { Id = Guid.NewGuid(), CategoryId = (int) ProductCategories.Construccion, Name = "Martillo Doble Golpe", Description = "Para mostrar la fuerza que no tienes.", Price = 7360 },
        ];

        Product[] modaProducts = 
        [
            new() { Id = Guid.NewGuid(), CategoryId = (int) ProductCategories.Moda, Name = "Miembro a Escala", Description = "Magnificado a escala con lujo de detalles. Para estudiar lo que no puedes ver.", Price = 7360 },
        ];

        List<Product> products = new();
        products.AddRange(cocinaProducts);
        products.AddRange(decoProducts);
        products.AddRange(pasatiemposProducts);
        products.AddRange(tecnologiaProducts);
        products.AddRange(construccionProducts);
        products.AddRange(modaProducts);

        builder.Entity<Product>()
            .HasData(products);
    }
}
