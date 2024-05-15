using Transbank.Webpay.WebpayPlus.Responses;

namespace Ferramas.Model.ViewModels;

public class PurchaseConfirmViewModel
{
    public bool Success {  get; set; }

    public PurchaseConfirmViewModel() { }

    public PurchaseConfirmViewModel(CommitResponse response)
    {
        Success = response.ResponseCode == 0;
    }
}
