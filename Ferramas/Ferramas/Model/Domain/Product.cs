namespace Ferramas.Model.Domain;

public sealed class Product
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string? Image { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    public string Description { get; set; }
    public float Price { get; set; }
}
