namespace Ferramas.Model.Domain;

public sealed class Cart
{
    public Guid Id { get; set; }
    public Guid? UserId {  get; set; }
    public FerraUser? User { get; set; }
    public string Details { get; set; }
}
