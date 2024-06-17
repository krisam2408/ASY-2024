using MaiSchatz.Abstracts;

namespace Ferramas.Model.DataTransfer;

public sealed class ExchangeResponse : IResponse
{
    public bool Success { get; set; }
    public int Timestamp { get; set; }
    public string Base {  get; set; }
    public DateTime Date { get; set; }
    public Dictionary<string, float> Rates { get; set; }
}
