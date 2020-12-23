using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AdminLayout.Models;
using AdminLayout.Areas.Admin.Data;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using AdminLayout.Areas.Admin.Models;

namespace AdminLayout.Controllers
{
    public class HomeController : Controller
    {
        private readonly DPContext _context;

        public HomeController(DPContext context)
        {
            _context = context;
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
                    ViewBag.listProductTop5 = _context.Product.ToList().TakeLast(5);
                    ViewBag.listCategory = _context.Category.ToList();
                    ViewBag.listSupplier = _context.Supplier.ToList();
                    return View();
                }
                else
                {
                    ViewBag.carts = dataCart;
                    ViewBag.listProduct = _context.Product.ToList();
                    ViewBag.listProductTop5 = _context.Product.ToList().TakeLast(5);
                    ViewBag.listCategory = _context.Category.ToList();
                    ViewBag.listSupplier = _context.Supplier.ToList();
                    return View();
                }
            }
            ViewBag.carts = null;
            ViewBag.listProduct = _context.Product.ToList();
            ViewBag.listProductTop5 = _context.Product.ToList().TakeLast(5);
            ViewBag.listCategory = _context.Category.ToList();
            ViewBag.listSupplier = _context.Supplier.ToList();
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
