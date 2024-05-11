using Ferramas.Extensions;
using Ferramas.Model.DataTransfer;
using MaiSchatz;
using Microsoft.AspNetCore.Mvc;

namespace Ferramas.Controllers;

public abstract class BaseController : Controller
{
    public const string BaseLayout = "~/Views/Shared/Layouts/_BaseLayout.cshtml";
    public const string HeaderPartial = "~/Views/Shared/Partials/_Header.cshtml";
    public const string FooterPartial = "~/Views/Shared/Partials/_Footer.cshtml";
    public const string ProductRowPartial = "~/Views/Cart/_ProductRowPartial.cshtml";

    public const float USDFactor = 0.0011f;

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

    protected async Task<KeyValuePair<bool, float>> ExchangeRequest(MeinMai caller)
    {
        try
        {
            ExchangeResponse? response = await caller
                .CallAsync<ExchangeResponse>();

            if (response == null)
            {
                return new(false, USDFactor);
            }

            if (!response.Success)
            {
                return new(false, USDFactor);
            }

            float clp = response.Rates["CLP"];
            float usd = response.Rates["USD"];
            float factor = usd / clp;

            return new(true, factor);
        }
        catch (Exception)
        {
            return new(false, USDFactor);
        }
    }
}
