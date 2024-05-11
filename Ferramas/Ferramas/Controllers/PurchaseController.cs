using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Ferramas.Controllers;

[Authorize]
public sealed class PurchaseController : BaseController
{
    private const long RedCompraApproved = 4051884239937763;
    private const long RedCompraDeclined = 5186008541233829;
    private const long CommercialCode = 597055555532;

    public IActionResult PurchaseProduct(string id)
    {
        Guid productId = Guid.Parse(id);

        return RedirectToAction("index", "home");
    }

    public IActionResult PurchaseCart(string id)
    {
        Guid cartId = Guid.Parse(id);

        return RedirectToAction("index", "home");
    }
}
