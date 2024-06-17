using Ferramas.Model;
using Ferramas.Model.DataTransfer;
using Ferramas.Model.Domain;
using Ferramas.Model.ViewModels;
using MaiSchatz.Abstracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ferramas.Controllers;

public sealed class ProductController : BaseController
{
    private readonly FerraContext m_context;
    private readonly IMeinMai m_exchangeApi;

    public ProductController(FerraContext context, IMeinMai exchange, bool isMocked = false) : base(isMocked)
    {
        m_context = context;
        m_exchangeApi = exchange;
    }

    public async Task<IActionResult> List(string category)
    {
        Product[] products = await ListProducts(category);

        if (products.Length == 0)
            return RedirectToAction("index", "home");

        List<JsonProduct> result = await HandleJsonProducts(products);

        ProductListViewModel model = new()
        {
            Title = category,
            Products = result.ToArray()
        };

        return View(model);
    }

    public async Task<IActionResult> Product(string id)
    {
        Guid productId = Guid.Parse(id);

        Product product = await m_context
            .Products
            .Include(p => p.Category)
            .FirstAsync(p => p.Id == productId);

        KeyValuePair<bool, float> exchangeResult = await ExchangeRequest(m_exchangeApi);

        JsonProduct model = await JsonProduct.Create(product, exchangeResult);

        return View(model);
    }

    [HttpGet, Route("api/products/")]
    public async Task<JsonResult> Products()
    {
        Product[] products = await m_context
            .Products
            .Include(p => p.Category)
            .ToArrayAsync();

        List<JsonProduct> result = await HandleJsonProducts(products);

        return Json(result);
    }

    [HttpGet, Route("api/products/byCategory/{category}")]
    public async Task<IActionResult> ListByCategory(string category)
    {
        Product[] products = await ListProducts(category);
        if (products.Length == 0)
            return BadRequest();

        List<JsonProduct> result = await HandleJsonProducts(products);

        return Json(result);
    }

    [HttpGet, Route("api/products/byId/{id}")]
    public async Task<IActionResult> ProductById(string id)
    {
        if(Guid.TryParse(id, out Guid productId))
        {
            Product? product = await m_context
                .Products
                .Include(p => p.Category)
                .FirstOrDefaultAsync(p => p.Id == productId);

            if(product == null)
                return NotFound();

            KeyValuePair<bool, float> exchangeResult = await ExchangeRequest(m_exchangeApi);
            JsonProduct result = await JsonProduct.Create(product, exchangeResult);

            return Json(result);
        }

        return BadRequest();
    }

    private async Task<Product[]> ListProducts(string category)
    {
        Category? categoryInstance = await m_context
            .Categories
            .FirstOrDefaultAsync(c => c.Name == category);

        if (categoryInstance == null)
            return Array.Empty<Product>();

        Product[] products = await m_context
            .Products
            .Include(p => p.Category)
            .Where(p => p.CategoryId == categoryInstance.Id)
            .ToArrayAsync();

        return products;
    }

    private async Task<List<JsonProduct>> HandleJsonProducts(Product[] products)
    {
        List<JsonProduct> result = new();

        KeyValuePair<bool, float> exchangeResult = await ExchangeRequest(m_exchangeApi);

        foreach (Product product in products)
        {
            JsonProduct jProduct = await JsonProduct.Create(product, exchangeResult);
            result.Add(jProduct);
        }

        return result;
    }
}
