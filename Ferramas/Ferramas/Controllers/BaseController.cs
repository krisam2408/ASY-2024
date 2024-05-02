using Microsoft.AspNetCore.Mvc;

namespace Ferramas.Controllers;

public abstract class BaseController : Controller
{
    public const string BaseLayout = "~/Views/Shared/Layouts/_BaseLayout.cshtml";
    public const string HeaderPartial = "~/Views/Shared/Partials/_Header.cshtml";
    public const string FooterPartial = "~/Views/Shared/Partials/_Footer.cshtml";

    public IActionResult Index()
    {
        return View();
    }
}
