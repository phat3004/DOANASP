using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AdminLayout.Areas.Admin.Data;
using AdminLayout.Areas.Admin.Models;
using AdminLayout.Models;
using AutoMapper;
using EmailService;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace AdminLayout.Controllers
{
    public class AccountController : Controller
    {
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly DPContext _context;
        private readonly IEmailSender _emailSender;

        public AccountController(IMapper mapper, UserManager<User> userManager, SignInManager<User> signInManager, DPContext context, IEmailSender emailSender)
        {
            _mapper = mapper;
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
            _emailSender = emailSender;
        }
        public IActionResult Index()
        {
            var cart = HttpContext.Session.GetString("cart");
            if (cart != null)
            {
                List<Cart> dataCart = JsonConvert.DeserializeObject<List<Cart>>(cart);
                if (dataCart.Count > 0)
                {
                    ViewBag.carts = dataCart;
                    ViewBag.listProduct = _context.Product.ToList();
                    ViewBag.listProductTop4 = _context.Product.ToList().TakeLast(4);
                    ViewBag.listCategory = _context.Category.ToList();
                    ViewBag.listSupplier = _context.Supplier.ToList();
                    return View();
                }
            }
            ViewBag.carts = null;
            ViewBag.listProduct = _context.Product.ToList();
            ViewBag.listProductTop4 = _context.Product.ToList().TakeLast(4);
            ViewBag.listCategory = _context.Category.ToList();
            ViewBag.listSupplier = _context.Supplier.ToList();
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            var cart = HttpContext.Session.GetString("cart");
            if (cart != null)
            {
                List<Cart> dataCart = JsonConvert.DeserializeObject<List<Cart>>(cart);
                if (dataCart.Count > 0)
                {
                    ViewBag.carts = dataCart;
                    ViewBag.listProduct = _context.Product.ToList();
                    ViewBag.listProductTop4 = _context.Product.ToList().TakeLast(4);
                    ViewBag.listCategory = _context.Category.ToList();
                    ViewBag.listSupplier = _context.Supplier.ToList();
                    return View();
                }
            }
            ViewBag.carts = null;
            ViewBag.listProduct = _context.Product.ToList();
            ViewBag.listProductTop4 = _context.Product.ToList().TakeLast(4);
            ViewBag.listCategory = _context.Category.ToList();
            ViewBag.listSupplier = _context.Supplier.ToList();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(UserRegistrationModel userModel)
        {
            var cart = HttpContext.Session.GetString("cart");
            if (cart != null)
            {
                List<Cart> dataCart = JsonConvert.DeserializeObject<List<Cart>>(cart);
                if (dataCart.Count > 0)
                {
                    ViewBag.carts = dataCart;
                    ViewBag.listProduct = _context.Product.ToList();
                    ViewBag.listProductTop4 = _context.Product.ToList().TakeLast(4);
                    ViewBag.listCategory = _context.Category.ToList();
                    ViewBag.listSupplier = _context.Supplier.ToList();
                    return View();
                }
            }
            ViewBag.carts = null;
            ViewBag.listProduct = _context.Product.ToList();
            ViewBag.listProductTop4 = _context.Product.ToList().TakeLast(4);
            ViewBag.listCategory = _context.Category.ToList();
            ViewBag.listSupplier = _context.Supplier.ToList();
            if (!ModelState.IsValid)
            {
                return View(userModel);
            }

            var user = _mapper.Map<User>(userModel);

            var result = await _userManager.CreateAsync(user, userModel.Password);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.TryAddModelError(error.Code, error.Description);
                }

                return View(userModel);
            }

            var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            var confirmationLink = Url.Action(nameof(ConfirmEmail), "Account", new { token, email = user.Email }, Request.Scheme);

            var message = new Message(new string[] { "0306181161@caothang.edu.vn" }, "Confirmation email link", confirmationLink, null);
            await _emailSender.SendEmailAsync(message);

            await _userManager.AddToRoleAsync(user, "Visitor");

            return RedirectToAction(nameof(SuccessRegistration));
        }

        [HttpGet]
        public async Task<IActionResult> ConfirmEmail(string token, string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user == null)
                return View("Error");
            var result = await _userManager.ConfirmEmailAsync(user, token);
            return View(result.Succeeded ? nameof(ConfirmEmail) : "Error");
        }

        [HttpGet]
        public IActionResult SuccessRegistration()
        {
            var cart = HttpContext.Session.GetString("cart");
            if (cart != null)
            {
                List<Cart> dataCart = JsonConvert.DeserializeObject<List<Cart>>(cart);
                if (dataCart.Count > 0)
                {
                    ViewBag.carts = dataCart;
                    ViewBag.listProduct = _context.Product.ToList();
                    ViewBag.listProductTop4 = _context.Product.ToList().TakeLast(4);
                    ViewBag.listCategory = _context.Category.ToList();
                    ViewBag.listSupplier = _context.Supplier.ToList();
                    return View();
                }
            }
            ViewBag.carts = null;
            ViewBag.listProduct = _context.Product.ToList();
            ViewBag.listProductTop4 = _context.Product.ToList().TakeLast(4);
            ViewBag.listCategory = _context.Category.ToList();
            ViewBag.listSupplier = _context.Supplier.ToList();
            return View();
        }

        [HttpGet]
        public IActionResult Login(string returnUrl = null)
        {
            var cart = HttpContext.Session.GetString("cart");
            if (cart != null)
            {
                List<Cart> dataCart = JsonConvert.DeserializeObject<List<Cart>>(cart);
                if (dataCart.Count > 0)
                {
                    ViewBag.carts = dataCart;
                    ViewBag.listProduct = _context.Product.ToList();
                    ViewBag.listProductTop4 = _context.Product.ToList().TakeLast(4);
                    ViewBag.listCategory = _context.Category.ToList();
                    ViewBag.listSupplier = _context.Supplier.ToList();
                    return View();
                }
            }
            ViewBag.carts = null;
            ViewBag.listProduct = _context.Product.ToList();
            ViewBag.listProductTop4 = _context.Product.ToList().TakeLast(4);
            ViewBag.listCategory = _context.Category.ToList();
            ViewBag.listSupplier = _context.Supplier.ToList();
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(AdminLayout.Models.UserLoginModel userModel, string returnUrl = null)
        {

            var cart = HttpContext.Session.GetString("cart");
            if (cart != null)
            {
                List<Cart> dataCart = JsonConvert.DeserializeObject<List<Cart>>(cart);
                if (dataCart.Count > 0)
                {
                    ViewBag.carts = dataCart;
                    ViewBag.listProduct = _context.Product.ToList();
                    ViewBag.listProductTop4 = _context.Product.ToList().TakeLast(4);
                    ViewBag.listCategory = _context.Category.ToList();
                    ViewBag.listSupplier = _context.Supplier.ToList();
                    return View();
                }
            }
            ViewBag.carts = null;
            ViewBag.listProduct = _context.Product.ToList();
            ViewBag.listProductTop4 = _context.Product.ToList().TakeLast(4);
            ViewBag.listCategory = _context.Category.ToList();
            ViewBag.listSupplier = _context.Supplier.ToList();


            if (!ModelState.IsValid)
            {
                return View(userModel);
            }

            var result = await _signInManager.PasswordSignInAsync(userModel.Email, userModel.Password, userModel.RememberMe, false);          
            if (result.Succeeded)
            {
                var user = await _context.Users.FirstOrDefaultAsync(m => m.Email == userModel.Email);
                return await RedirectToLocal(returnUrl, user);
            }
            else
            {
                ModelState.AddModelError("", "Invalid Login Attempt");
                return View();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ExternalLogin(string provider, string returnUrl = null)
        {
            var redirectUrl = Url.Action(nameof(ExternalLoginCallback), "Account", new { returnUrl });
            var properties = _signInManager.ConfigureExternalAuthenticationProperties(provider, redirectUrl);
            return Challenge(properties, provider);
        }

        [HttpGet]
        public async Task<IActionResult> ExternalLoginCallback(string returnUrl = null)
        {
            var cart = HttpContext.Session.GetString("cart");
            if (cart != null)
            {
                List<Cart> dataCart = JsonConvert.DeserializeObject<List<Cart>>(cart);
                if (dataCart.Count > 0)
                {
                    ViewBag.carts = dataCart;
                    ViewBag.listProduct = _context.Product.ToList();
                    ViewBag.listProductTop4 = _context.Product.ToList().TakeLast(4);
                    ViewBag.listCategory = _context.Category.ToList();
                    ViewBag.listSupplier = _context.Supplier.ToList();
                    return View();
                }
            }
            ViewBag.carts = null;
            ViewBag.listProduct = _context.Product.ToList();
            ViewBag.listProductTop4 = _context.Product.ToList().TakeLast(4);
            ViewBag.listCategory = _context.Category.ToList();
            ViewBag.listSupplier = _context.Supplier.ToList();


            var info = await _signInManager.GetExternalLoginInfoAsync();
            if (info == null)
            {
                return RedirectToAction(nameof(Login));
            }

            var signInResult = await _signInManager.ExternalLoginSignInAsync(info.LoginProvider, info.ProviderKey, isPersistent: false, bypassTwoFactor: true);
            if (signInResult.Succeeded)
            {
                return await RedirectToLocal(returnUrl, new User());
            }
            if (signInResult.IsLockedOut)
            {
                return RedirectToAction(nameof(ForgotPassword));
            }
            else
            {
                ViewData["ReturnUrl"] = returnUrl;
                ViewData["Provider"] = info.LoginProvider;
                var email = info.Principal.FindFirstValue(ClaimTypes.Email);
                return View("ExternalLogin", new ExternalLoginModel { Email = email });
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ExternalLoginConfirmation(ExternalLoginModel model, string returnUrl = null)
        {
            var cart = HttpContext.Session.GetString("cart");
            if (cart != null)
            {
                List<Cart> dataCart = JsonConvert.DeserializeObject<List<Cart>>(cart);
                if (dataCart.Count > 0)
                {
                    ViewBag.carts = dataCart;
                    ViewBag.listProduct = _context.Product.ToList();
                    ViewBag.listProductTop4 = _context.Product.ToList().TakeLast(4);
                    ViewBag.listCategory = _context.Category.ToList();
                    ViewBag.listSupplier = _context.Supplier.ToList();
                    return View();
                }
            }
            ViewBag.carts = null;
            ViewBag.listProduct = _context.Product.ToList();
            ViewBag.listProductTop4 = _context.Product.ToList().TakeLast(4);
            ViewBag.listCategory = _context.Category.ToList();
            ViewBag.listSupplier = _context.Supplier.ToList();

            if (!ModelState.IsValid)
                return View(model);

            var info = await _signInManager.GetExternalLoginInfoAsync();
            if (info == null)
                return View(nameof(Error));

            var user = await _userManager.FindByEmailAsync(model.Email);
            IdentityResult result;

            if (user != null)
            {
                result = await _userManager.AddLoginAsync(user, info);
                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return await RedirectToLocal(returnUrl, user);
                }
            }
            else
            {
                model.Principal = info.Principal;
                user = _mapper.Map<User>(model);
                user.EmailConfirmed = true;
                result = await _userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    result = await _userManager.AddLoginAsync(user, info);
                    if (result.Succeeded)
                    {
                        //TODO: Send an emal for the email confirmation and add a default role as in the Register action
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return await RedirectToLocal(returnUrl, user);
                    }
                }
            }

            foreach (var error in result.Errors)
            {
                ModelState.TryAddModelError(error.Code, error.Description);
            }

            return View(nameof(ExternalLogin), model);
        }

        [HttpGet]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction(nameof(HomeController.Index), "Home");
        }

        private async Task<IActionResult> RedirectToLocal(string returnUrl,User user)
        {
            bool isAdmin = await _userManager.IsInRoleAsync(user, "Administrator");

            if (isAdmin)
            {
                return RedirectToAction(nameof(HomeController.Index), "Home", new { area ="Admin"});
            }
            else
            {
                if (Url.IsLocalUrl(returnUrl))
                    return Redirect(returnUrl);
                else
                    return RedirectToAction(nameof(HomeController.Index), "Home");
            }

        }
        [HttpGet]
        public IActionResult ForgotPassword()
        {
            var cart = HttpContext.Session.GetString("cart");
            if (cart != null)
            {
                List<Cart> dataCart = JsonConvert.DeserializeObject<List<Cart>>(cart);
                if (dataCart.Count > 0)
                {
                    ViewBag.carts = dataCart;
                    ViewBag.listProduct = _context.Product.ToList();
                    ViewBag.listProductTop4 = _context.Product.ToList().TakeLast(4);
                    ViewBag.listCategory = _context.Category.ToList();
                    ViewBag.listSupplier = _context.Supplier.ToList();
                    return View();
                }
            }
            ViewBag.carts = null;
            ViewBag.listProduct = _context.Product.ToList();
            ViewBag.listProductTop4 = _context.Product.ToList().TakeLast(4);
            ViewBag.listCategory = _context.Category.ToList();
            ViewBag.listSupplier = _context.Supplier.ToList();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordModel forgotPasswordModel)
        {
            if (!ModelState.IsValid)
                return View(forgotPasswordModel);

            var user = await _userManager.FindByEmailAsync(forgotPasswordModel.Email);
            if (user == null)
                return RedirectToAction(nameof(ForgotPasswordConfirmation));

            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            var callback = Url.Action(nameof(ResetPassword), "Account", new { token, email = user.Email }, Request.Scheme);

            var message = new Message(new string[] { "0306181161@caothang.edu.vn" }, "Reset password token", callback, null);
            await _emailSender.SendEmailAsync(message);

            return RedirectToAction(nameof(ForgotPasswordConfirmation));
        }

        public IActionResult ForgotPasswordConfirmation()
        {
            var cart = HttpContext.Session.GetString("cart");
            if (cart != null)
            {
                List<Cart> dataCart = JsonConvert.DeserializeObject<List<Cart>>(cart);
                if (dataCart.Count > 0)
                {
                    ViewBag.carts = dataCart;
                    ViewBag.listProduct = _context.Product.ToList();
                    ViewBag.listProductTop4 = _context.Product.ToList().TakeLast(4);
                    ViewBag.listCategory = _context.Category.ToList();
                    ViewBag.listSupplier = _context.Supplier.ToList();
                    return View();
                }
            }
            ViewBag.carts = null;
            ViewBag.listProduct = _context.Product.ToList();
            ViewBag.listProductTop4 = _context.Product.ToList().TakeLast(4);
            ViewBag.listCategory = _context.Category.ToList();
            ViewBag.listSupplier = _context.Supplier.ToList();
            return View();
        }

        [HttpGet]
        public IActionResult ResetPassword(string token, string email)
        {
            var cart = HttpContext.Session.GetString("cart");
            if (cart != null)
            {
                List<Cart> dataCart = JsonConvert.DeserializeObject<List<Cart>>(cart);
                if (dataCart.Count > 0)
                {
                    ViewBag.carts = dataCart;
                    ViewBag.listProduct = _context.Product.ToList();
                    ViewBag.listProductTop4 = _context.Product.ToList().TakeLast(4);
                    ViewBag.listCategory = _context.Category.ToList();
                    ViewBag.listSupplier = _context.Supplier.ToList();
                    return View();
                }
            }
            ViewBag.carts = null;
            ViewBag.listProduct = _context.Product.ToList();
            ViewBag.listProductTop4 = _context.Product.ToList().TakeLast(4);
            ViewBag.listCategory = _context.Category.ToList();
            ViewBag.listSupplier = _context.Supplier.ToList();
            var model = new ResetPasswordModel { Token = token, Email = email };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPassword(ResetPasswordModel resetPasswordModel)
        {
            if (!ModelState.IsValid)
                return View(resetPasswordModel);
            var user = await _userManager.FindByEmailAsync(resetPasswordModel.Email);
            if (user == null)
                RedirectToAction(nameof(ResetPasswordConfirmation));
            var resetPassResult = await _userManager.ResetPasswordAsync(user, resetPasswordModel.Token, resetPasswordModel.Password);
            if (!resetPassResult.Succeeded)
            {
                foreach (var error in resetPassResult.Errors)
                {
                    ModelState.TryAddModelError(error.Code, error.Description);
                }
                return View();
            }
            return RedirectToAction(nameof(ResetPasswordConfirmation));
        }

        [HttpGet]
        public IActionResult ResetPasswordConfirmation()
        {
            var cart = HttpContext.Session.GetString("cart");
            if (cart != null)
            {
                List<Cart> dataCart = JsonConvert.DeserializeObject<List<Cart>>(cart);
                if (dataCart.Count > 0)
                {
                    ViewBag.carts = dataCart;
                    ViewBag.listProduct = _context.Product.ToList();
                    ViewBag.listProductTop4 = _context.Product.ToList().TakeLast(4);
                    ViewBag.listCategory = _context.Category.ToList();
                    ViewBag.listSupplier = _context.Supplier.ToList();
                    return View();
                }
            }
            ViewBag.carts = null;
            ViewBag.listProduct = _context.Product.ToList();
            ViewBag.listProductTop4 = _context.Product.ToList().TakeLast(4);
            ViewBag.listCategory = _context.Category.ToList();
            ViewBag.listSupplier = _context.Supplier.ToList();
            return View();
        }

        [HttpGet]
        public IActionResult Error()
        {
            var cart = HttpContext.Session.GetString("cart");
            if (cart != null)
            {
                List<Cart> dataCart = JsonConvert.DeserializeObject<List<Cart>>(cart);
                if (dataCart.Count > 0)
                {
                    ViewBag.carts = dataCart;
                    ViewBag.listProduct = _context.Product.ToList();
                    ViewBag.listProductTop4 = _context.Product.ToList().TakeLast(4);
                    ViewBag.listCategory = _context.Category.ToList();
                    ViewBag.listSupplier = _context.Supplier.ToList();
                    return View();
                }
            }
            ViewBag.carts = null;
            ViewBag.listProduct = _context.Product.ToList();
            ViewBag.listProductTop4 = _context.Product.ToList().TakeLast(4);
            ViewBag.listCategory = _context.Category.ToList();
            ViewBag.listSupplier = _context.Supplier.ToList();
            return View();
        }

        public IActionResult AccessDenied()
        {
            var cart = HttpContext.Session.GetString("cart");
            if (cart != null)
            {
                List<Cart> dataCart = JsonConvert.DeserializeObject<List<Cart>>(cart);
                if (dataCart.Count > 0)
                {
                    ViewBag.carts = dataCart;
                    ViewBag.listProduct = _context.Product.ToList();
                    ViewBag.listProductTop4 = _context.Product.ToList().TakeLast(4);
                    ViewBag.listCategory = _context.Category.ToList();
                    ViewBag.listSupplier = _context.Supplier.ToList();
                    return View();
                }
            }
            ViewBag.carts = null;
            ViewBag.listProduct = _context.Product.ToList();
            ViewBag.listProductTop4 = _context.Product.ToList().TakeLast(4);
            ViewBag.listCategory = _context.Category.ToList();
            ViewBag.listSupplier = _context.Supplier.ToList();
            return View();
        }
    }
}
