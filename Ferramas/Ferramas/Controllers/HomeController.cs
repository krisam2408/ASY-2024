using Ferramas.Model;
using Ferramas.Model.Domain;
using Ferramas.Model.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ferramas.Controllers;

[AllowAnonymous]
public class HomeController : BaseController
{
    private readonly FerraContext m_context;

    public HomeController(FerraContext context)
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
}
