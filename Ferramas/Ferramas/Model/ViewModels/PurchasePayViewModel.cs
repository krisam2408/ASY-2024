using Transbank.Webpay.WebpayPlus.Responses;

namespace Ferramas.Model.ViewModels;

public class PurchasePayViewModel
{
    public string Token { get; set; }
    public string Url { get; set; }

    public PurchasePayViewModel() { }

    public PurchasePayViewModel(CreateResponse response)
    {
        Token = response.Token;
        Url = response.Url;
    }
}
