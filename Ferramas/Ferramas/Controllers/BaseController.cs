using Ferramas.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace Ferramas.Controllers;

public abstract class BaseController : Controller
{
    public const string BaseLayout = "~/Views/Shared/Layouts/_BaseLayout.cshtml";
    public const string HeaderPartial = "~/Views/Shared/Partials/_Header.cshtml";
    public const string FooterPartial = "~/Views/Shared/Partials/_Footer.cshtml";

    protected virtual void CommonDataTransfer()
    {
        ViewData["Auth"] = HttpContext.IsAuthenticated();
    }

    protected new ViewResult View()
    {
        CommonDataTransfer();
        return base.View();
    }

    protected new ViewResult View(string viewName)
    {
        CommonDataTransfer();
        return base.View(viewName);
    }

    protected new ViewResult View(object model)
    {
        CommonDataTransfer();
        return base.View(model);
    }

    protected new ViewResult View(string viewName, object model)
    {
        CommonDataTransfer();
        return base.View(viewName, model);
    }
}
