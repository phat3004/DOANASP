using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminLayout.Areas.Admin.Data;
using AdminLayout.Areas.Admin.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace AdminLayout.Controllers
{
    public class DetailController : Controller
    {
        private readonly DPContext _context;

        public DetailController(DPContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int? id)
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
                    var postModel2 = await _context.Product
                       .Include(p => p.Category)
                       .FirstOrDefaultAsync(m => m.ProductID == id);
                    return View(postModel2);
                }
            }
            ViewBag.carts = null;
            ViewBag.listProduct = _context.Product.ToList();
            ViewBag.listProductTop5 = _context.Product.ToList().TakeLast(5);
            ViewBag.listCategory = _context.Category.ToList();
            ViewBag.listSupplier = _context.Supplier.ToList();
            var postModel = await _context.Product
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.ProductID == id);
            return View(postModel);
        }
    }
}
