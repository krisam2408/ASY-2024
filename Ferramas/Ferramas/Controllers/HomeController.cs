using Ferramas.Extensions;
using Ferramas.Model;
using Ferramas.Model.DataTransfer;
using Ferramas.Model.Domain;
using Ferramas.Model.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ferramas.Controllers;

[AllowAnonymous]
public class HomeController : BaseController
{
    private readonly IFerraDb m_context;

    public HomeController(IFerraDb context)
    {
        m_context = context;
    }

    public async Task<IActionResult> Index()
    {
        Category[] categories = await m_context
            .Categories
            .ToArrayAsync();

        HomeIndexViewModel model = new()
        {
            Categories = categories
        };

        return View(model);
    }

    public IActionResult Subscribe()
    {
        return View();
    }

    [HttpPost, ValidateAntiForgeryToken]
    public async Task<IActionResult> Subscribe(string email)
    {
        Subscription? sub = await m_context
            .Subscriptions
            .FirstOrDefaultAsync(s => s.Email == email);

        if(sub != null)
            return View();

        sub = new()
        {
            Id = Guid.NewGuid(),
            Email = email
        };

        await m_context
            .Subscriptions
            .InsertAsync(sub);

        await m_context.SaveChangesAsync();

        return RedirectToAction("index");
    }
}
