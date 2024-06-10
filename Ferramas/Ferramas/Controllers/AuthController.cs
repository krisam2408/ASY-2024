using Ferramas.Extensions;
using Ferramas.Model;
using Ferramas.Model.DataTransfer;
using Ferramas.Model.Domain;
using Ferramas.Model.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace Ferramas.Controllers
{
    [AllowAnonymous]
    public sealed class AuthController : BaseController
    {
        private readonly IFerraDb m_context;

        public AuthController(IFerraDb context)
        {
            m_context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(AuthLoginViewModel model)
        {
            if (!ModelState.IsValid)
                return RedirectToAction("index");

            FerraUser? user = await m_context
                .Users
                .FirstOrDefaultAsync(u => u.Email == model.Email);

            if(user == null)
                return RedirectToAction("index");

            if(model.Password != user.PasswordHash)
                return RedirectToAction("index");

            ClaimsPrincipal principal = user.CreatePrincipalIdentity();

            await HttpContext.SignInAsync(principal);

            return RedirectToAction("index", "home");
        }

        [Route("api/handshake")]
        public IActionResult Handshake()
        {
            return Ok("200");
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("index", "home");
        }
    }
}
