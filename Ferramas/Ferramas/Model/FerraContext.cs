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

        builder.Entity<Subscription>()
            .HasIndex(k => k.Email)
            .IsUnique();
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
            new() { Id = Guid.NewGuid(), CategoryId = (int) ProductCategories.Cocina, Name = "Aceite en Polvo", Description = "Para hacerte el hipster y decir que cocinas todo con agua.", Price = 6500, Image="aceite.jpg"},
            new() { Id = Guid.NewGuid(), CategoryId = (int) ProductCategories.Cocina, Name = "Soda caustica en formato salero", Description = "Un buen producto para nuestros amantes de la cocina, solo no te vayas a equivocar de salero", Price = 1200 , Image="sal.webp"},
            new() { Id = Guid.NewGuid(), CategoryId = (int) ProductCategories.Cocina, Name = "NOT MAYO", Description = "Mayo vegana con hierro extra para nuestros anemicos favoritos", Price = 3500, Image="mayo.jpg" }
        ];

        Product[] decoProducts = 
        [
            new() { Id = Guid.NewGuid(), CategoryId = (int) ProductCategories.DecoHogar, Name = "Látigo con Puntas de Cobre", Description = "Para demostrarle a Dios que eres impuro pero cuidas de tu salud.", Price = 13250, Image="cuerda1.webp" },
            new() { Id = Guid.NewGuid(), CategoryId = (int) ProductCategories.DecoHogar, Name = "Tostador chileno", Description = "Para hacer el pan de los dioses", Price = 5000, Image="Tostador.jpg"},
            new() { Id = Guid.NewGuid(), CategoryId = (int) ProductCategories.DecoHogar, Name = "Ventana de hielo 7", Description = "Una ventana que te permitira ver el otro mundo", Price = 1000, Image="Hielo7.gif"},
        ];

        Product[] pasatiemposProducts = 
        [
            new() { Id = Guid.NewGuid(), CategoryId = (int) ProductCategories.Pasatiempos, Name = "Látigo con Puntas Sin Filo", Description = "Para disfrazarte de alguien que se cree impuro.", Price = 10250, Image="cuerda2.jpg"},
            new() { Id = Guid.NewGuid(), CategoryId = (int) ProductCategories.Pasatiempos, Name = "Hagalo usted mismo manual", Description = "Si te sientes inutil, entonces no haz conocido este manual", Price = 7500, Image="Diccionario.jpg"},
            new() { Id = Guid.NewGuid(), CategoryId = (int) ProductCategories.Pasatiempos, Name = "Pelota cuadrada de acero reforzado", Description = "Pateala y el hospital te esperara", Price = 2000, Image="Pelota.jpg"},
        ];

        Product[] tecnologiaProducts = 
        [
            new() { Id = Guid.NewGuid(), CategoryId = (int) ProductCategories.Teconologia, Name = "Multiantena de Fierro", Description = "Para escuchar ese zumbido que molesta a tus vecinos y ver los canales que no te gustan.", Price = 6350, Image="Antena.jpg"},
            new() { Id = Guid.NewGuid(), CategoryId = (int) ProductCategories.Teconologia, Name = "Iphone con bateria incluida", Description = "Finge estatus pero con algo de cerebro", Price = 1000000, Image="Iphone.webp"},
            new() { Id = Guid.NewGuid(), CategoryId = (int) ProductCategories.Teconologia, Name = "Television invisible", Description = "Un televisor invisible,no hay mas descripcion", Price = 256000, Image="nada.jpg"},
        ];

        Product[] construccionProducts = 
        [
            new() { Id = Guid.NewGuid(), CategoryId = (int) ProductCategories.Construccion, Name = "Martillo Doble Golpe", Description = "Para mostrar la fuerza que no tienes.", Price = 7360, Image="martillo.jpg"},
            new() { Id = Guid.NewGuid(), CategoryId = (int) ProductCategories.Construccion, Name = "Cable inalambrico", Description = "Ideal para construir aeroplanos", Price = 6000, Image="inalambrico.jpg"},
            new() { Id = Guid.NewGuid(), CategoryId = (int) ProductCategories.Construccion, Name = "Cadena perpetua", Description = "En el pais no existe", Price = 9000, Image="cadenai.jpg"},
        ];

        Product[] modaProducts = 
        [
            new() { Id = Guid.NewGuid(), CategoryId = (int) ProductCategories.Moda, Name = "Miembro a Escala", Description = "Magnificado a escala con lujo de detalles. Para estudiar lo que no puedes ver.", Price = 7360, Image="p.webp"},
            new() { Id = Guid.NewGuid(), CategoryId = (int) ProductCategories.Moda, Name = "Cosplay de enfermera", Description = "Prenda que trae sorpresa", Price = 4990, Image="cosplay.webp"},
            new() { Id = Guid.NewGuid(), CategoryId = (int) ProductCategories.Moda, Name = "Blindaje anti portonazo", Description = "La mejor ropa blindada para visitar puente alto", Price = 10, Image="ropa.jpg"},
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
