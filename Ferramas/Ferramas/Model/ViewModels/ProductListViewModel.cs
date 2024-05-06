using Ferramas.Model.DataTransfer;

namespace Ferramas.Model.ViewModels;

public class ProductListViewModel
{
    public string Title { get; set; }
    public JsonProduct[] Products { get; set; }
}
