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
    public class CategoryController : Controller
    {
        private readonly DPContext _context;

        public CategoryController(DPContext context)
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
                    ViewBag.listCategory = _context.Category.ToList();
                    ViewBag.listSupplier = _context.Supplier.ToList();
                    var list2 = from m in _context.Product select m;
                    list2 = list2.Where(m => m.CategoryID.Equals(id));
                    return View(await list2.ToListAsync());
                }
                else
                {
                    ViewBag.carts = dataCart;
                    ViewBag.listProduct = _context.Product.ToList();
                    ViewBag.listCategory = _context.Category.ToList();
                    ViewBag.listSupplier = _context.Supplier.ToList();
                    var list1 = from m in _context.Product select m;
                    list1 = list1.Where(m => m.CategoryID.Equals(id));
                    return View(await list1.ToListAsync());
                }
            }
            ViewBag.carts = null;
            ViewBag.listProduct = _context.Product.ToList();
            ViewBag.listCategory = _context.Category.ToList();
            ViewBag.listSupplier = _context.Supplier.ToList();
            var list = from m in _context.Product select m;
            list = list.Where(m => m.CategoryID.Equals(id));
            return View(await list.ToListAsync());
            
        }
    }
}
