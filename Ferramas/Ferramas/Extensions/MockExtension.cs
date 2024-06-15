using Ferramas.Model.Domain;

namespace Ferramas.Extensions;

public static class MockExtension
{
    public enum ProductCategories
    {
        Cocina = 1,
        DecoHogar,
        Pasatiempos,
        Teconologia,
        Construccion,
        Moda
    }

    public static FerraUser[] GetUsers()
    {
        FerraUser[] users = 
        [
            new() { Id = Guid.Parse("abe72a35-e19b-465d-ad34-21b5981f5837"), Name="Testerina", Surname="Tester", Email = "testerina@gmail.com", PasswordHash = "admin" },
            new() { Id = Guid.Parse("2c59b251-3b08-45b5-ab11-c092b32310d4"), Name="Armando", Surname="Casas", Email = "acasas@gmail.com", PasswordHash = "admin" },
            new() { Id = Guid.Parse("72ea3418-8d13-4293-866f-174d359c1c1d"), Name="Pedro", Surname="Palote", Email = "pe.palo@gmail.com", PasswordHash = "admin" },
        ];

        return users;
    }

    public static Category[] GetCategories()
    {
        return [
            new() { Id = (int) ProductCategories.Cocina, Name = "Comestibles / Cocina" },
            new() { Id = (int) ProductCategories.DecoHogar, Name = "DecoHogar" },
            new() { Id = (int) ProductCategories.Pasatiempos, Name = "Pasatiempos" },
            new() { Id = (int) ProductCategories.Teconologia, Name = "Tecnología" },
            new() { Id = (int) ProductCategories.Construccion, Name = "Construcción" },
            new() { Id = (int) ProductCategories.Moda, Name = "Moda" },
        ];
    }

    public static Product[] GetProducts()
    {
        List<Product> result = new();
        result.AddRange(GetKitchenProducts());
        result.AddRange(GetDecoProducts());
        result.AddRange(GetHobbyProducts());
        result.AddRange(GetTecnologyProducts());
        result.AddRange(GetConstructionProducts());
        result.AddRange(GetFashionProducts());

        return result.ToArray();
    }

    private static Product[] GetKitchenProducts()
    {
        return 
        [
            new() { Id = Guid.Parse("8b1589b4-0064-4665-ad8c-7b6cedc548ad"), CategoryId = (int) ProductCategories.Cocina, Name = "Aceite en Polvo", Description = "Para hacerte el hipster y decir que cocinas todo con agua.", Price = 6500, Image="aceite.jpg"},
            new() { Id = Guid.Parse("6c056e3a-6963-4c42-abaa-a19896106f9d"), CategoryId = (int) ProductCategories.Cocina, Name = "Soda caustica en formato salero", Description = "Un buen producto para nuestros amantes de la cocina, solo no te vayas a equivocar de salero", Price = 1200 , Image="sal.webp"},
            new() { Id = Guid.Parse("cff8d445-fcd6-4a47-a657-df677546962b"), CategoryId = (int) ProductCategories.Cocina, Name = "NOT MAYO", Description = "Mayo vegana con hierro extra para nuestros anemicos favoritos", Price = 3500, Image="mayo.jpg" }
        ];
    }

    private static Product[] GetDecoProducts()
    {
        return 
        [
            new() { Id = Guid.Parse("38f53404-c674-4258-bae1-1961556433d7"), CategoryId = (int) ProductCategories.DecoHogar, Name = "Látigo con Puntas de Cobre", Description = "Para demostrarle a Dios que eres impuro pero cuidas de tu salud.", Price = 13250, Image="cuerda1.webp" },
            new() { Id = Guid.Parse("a255e5fa-a1ce-491c-927b-81ec0c7040e5"), CategoryId = (int) ProductCategories.DecoHogar, Name = "Tostador chileno", Description = "Para hacer el pan de los dioses", Price = 5000, Image="Tostador.jpg"},
            new() { Id = Guid.Parse("6025ab8b-c379-44b3-81f5-218e6a5f69c1"), CategoryId = (int) ProductCategories.DecoHogar, Name = "Ventana de hielo 7", Description = "Una ventana que te permitira ver el otro mundo", Price = 1000, Image="Hielo7.gif"},
        ];
    }

    private static Product[] GetHobbyProducts()
    {
        return 
        [
            new() { Id = Guid.Parse("4a9af2b6-5527-4649-80df-b27fc4cad78e"), CategoryId = (int) ProductCategories.Pasatiempos, Name = "Látigo con Puntas Sin Filo", Description = "Para disfrazarte de alguien que se cree impuro.", Price = 10250, Image="cuerda2.jpg"},
            new() { Id = Guid.Parse("7cd5b969-f71e-40c5-9512-9ff63c6fdbf6"), CategoryId = (int) ProductCategories.Pasatiempos, Name = "Hagalo usted mismo manual", Description = "Si te sientes inutil, entonces no haz conocido este manual", Price = 7500, Image="Diccionario.jpg"},
            new() { Id = Guid.Parse("9a07e775-3007-4163-b009-c3afb3f37c05"), CategoryId = (int) ProductCategories.Pasatiempos, Name = "Pelota cuadrada de acero reforzado", Description = "Pateala y el hospital te esperara", Price = 2000, Image="Pelota.jpg"},
        ];
    }

    private static Product[] GetTecnologyProducts()
    {
        return 
        [
            new() { Id = Guid.Parse("c0622cdb-6902-4ae5-a973-e0835031d801"), CategoryId = (int) ProductCategories.Teconologia, Name = "Multiantena de Fierro", Description = "Para escuchar ese zumbido que molesta a tus vecinos y ver los canales que no te gustan.", Price = 6350, Image="Antena.jpg"},
            new() { Id = Guid.Parse("bfd9c8a1-28c0-4399-ab1c-0a924c1513f3"), CategoryId = (int) ProductCategories.Teconologia, Name = "Iphone con bateria incluida", Description = "Finge estatus pero con algo de cerebro", Price = 1000000, Image="Iphone.webp"},
            new() { Id = Guid.Parse("04d141b6-85b3-4d6e-ab56-ab014d45ffaf"), CategoryId = (int) ProductCategories.Teconologia, Name = "Television invisible", Description = "Un televisor invisible,no hay mas descripcion", Price = 256000, Image="nada.jpg"},
        ];
    }

    private static Product[] GetConstructionProducts()
    {
        return
        [
            new() { Id = Guid.Parse("13f2ff9b-8f94-4aab-849c-1bc022c2bd26"), CategoryId = (int) ProductCategories.Construccion, Name = "Martillo Doble Golpe", Description = "Para mostrar la fuerza que no tienes.", Price = 7360, Image="martillo.jpg"},
            new() { Id = Guid.Parse("737eb79f-9f13-47b8-8f65-e003e37e53df"), CategoryId = (int) ProductCategories.Construccion, Name = "Cable inalambrico", Description = "Ideal para construir aeroplanos", Price = 6000, Image="inalambrico.jpg"},
            new() { Id = Guid.Parse("9e045598-7d84-4672-9ac1-f9407865bbca"), CategoryId = (int) ProductCategories.Construccion, Name = "Cadena perpetua", Description = "En el pais no existe", Price = 9000, Image="cadenai.jpg"},
        ];
    }

    private static Product[] GetFashionProducts()
    {
        return
        [
            new() { Id = Guid.Parse("edd37239-1053-463a-b36e-7b49e3390917"), CategoryId = (int) ProductCategories.Moda, Name = "Miembro a Escala", Description = "Magnificado a escala con lujo de detalles. Para estudiar lo que no puedes ver.", Price = 7360, Image="p.webp"},
            new() { Id = Guid.Parse("9a153313-76f7-410f-a5ac-c18a7ec614a5"), CategoryId = (int) ProductCategories.Moda, Name = "Cosplay de enfermera", Description = "Prenda que trae sorpresa", Price = 4990, Image="cosplay.webp"},
            new() { Id = Guid.Parse("46c15c11-0f53-45ad-b8df-6b54a124d037"), CategoryId = (int) ProductCategories.Moda, Name = "Blindaje anti portonazo", Description = "La mejor ropa blindada para visitar puente alto", Price = 10, Image="ropa.jpg"},
        ];
    }
}


