using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminLayout.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AdminLayout.Areas.Admin.Controllers
{
    public class AdminHomeController : Controller
    {
        [Area("Admin")]
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login(string returnUrl)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            if (model.UserName == "admin" & model.Password == "123456")
            {

            }
            return View();
        }
    }
}
