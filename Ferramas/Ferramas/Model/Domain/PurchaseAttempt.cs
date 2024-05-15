namespace Ferramas.Model.Domain;

public sealed class PurchaseAttempt
{
    public Guid Id { get; set; }
    public Guid CartId { get; set; }
    public Cart Cart { get; set; }
    public string TransbankSession { get; set; }
    public float PurchasePrice { get; set; }
    public DateTime AttemptDate { get; set; }
    public bool Accepted { get; set; }
}
