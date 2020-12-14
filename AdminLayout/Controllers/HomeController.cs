using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AdminLayout.Models;
using AdminLayout.Areas.Admin.Data;
using AdminLayout.Areas.Admin.Models;
using Microsoft.EntityFrameworkCore;

namespace AdminLayout.Controllers
{
    public class HomeController : Controller
    {
        private readonly DPContext _context;

        public HomeController(DPContext context)
        {
            _context = context;
        }
        public IActionResult Login(string Email, string Pass)
        {
            if (!String.IsNullOrEmpty(Email) && !String.IsNullOrEmpty(Pass))
            {
                var custom = from c in _context.Customer
                             where c.Email == Email && c.Password == Pass
                             select new { c.Name };
                //var user =  _context.Customer
                //.FirstOrDefaultAsync(m => m.Email == Email &&  m.Password == Pass);
                return View("Index",custom);
            }
            else
            {
                return NotFound();
            }
        }
        public IActionResult Index(string? name)
        {
            ViewBag.USer = name;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
