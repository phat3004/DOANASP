using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AdminLayout.Areas.Admin.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AdminLayout.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class HomeController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login(string returnUrl = "")
        {
            this.ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async  Task<IActionResult> Login(LoginViewModel model, string? returnUrl)
        {
            this.ViewData["ReturnUrl"] = returnUrl;
            
            if (model is null || model.Email is null || model.Password is null)
            {
                this.ModelState.AddModelError(string.Empty, "EmailOrPasswordIsInvalid");
                return this.View(nameof(Login), model);
            }

            if (!this.ModelState.IsValid || !this.ValidateUser(model.Email, model.Password))
            {
                this.ModelState.AddModelError(string.Empty, "EmailOrPasswordIsInvalid");
                return this.View(nameof(Login), model);
            }

            var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);
            identity.AddClaim(new Claim(ClaimTypes.Name, model.Email));

            var principle = new ClaimsPrincipal(identity);
            var properties = new AuthenticationProperties { IsPersistent = model.RememberMe };
            await this.HttpContext.SignInAsync(principle, properties).ConfigureAwait(false);

            return this.LocalRedirect(returnUrl ?? "/admin");
        }

        private bool ValidateUser(string email, string password)
        {
            return email == "admin" && password == "123456";
        }
    }
}
