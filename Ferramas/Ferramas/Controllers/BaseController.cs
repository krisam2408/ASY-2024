using Ferramas.Extensions;
using Ferramas.Model.DataTransfer;
using MaiSchatz;
using MaiSchatz.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace Ferramas.Controllers;

public abstract class BaseController : Controller
{
    public const string BaseLayout = "~/Views/Shared/Layouts/_BaseLayout.cshtml";
    public const string HeaderPartial = "~/Views/Shared/Partials/_Header.cshtml";
    public const string FooterPartial = "~/Views/Shared/Partials/_Footer.cshtml";
    public const string ProductRowPartial = "~/Views/Cart/_ProductRowPartial.cshtml";

    public const float USDFactor = 0.0011f;

    public readonly bool IsMocked;

    protected BaseController(bool isMocked)
    {
        IsMocked = isMocked;
    }

    protected virtual void CommonDataTransfer()
    {
        ViewData["Auth"] = IsAuthenticated();
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

    protected async Task<KeyValuePair<bool, float>> ExchangeRequest(IMeinMai caller)
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

    protected bool IsAuthenticated()
    {
        if (IsMocked)
            return true;
        return HttpContext.IsAuthenticated();
    }

    protected string GetUserEmail()
    {
        if (IsMocked)
            return "testerina@gmail.com";
        return HttpContext.GetUserEmail();
    }

    protected string GetHostLocation()
    {
        if (IsMocked)
            return "https://localhost:7253";
        return $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host}";
    }
}
