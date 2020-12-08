using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminLayout.Areas.Admin.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
            ViewBag.listProduct = _context.Product.ToList();
            ViewBag.listCategory = _context.Category.ToList();
            ViewBag.listSupplier = _context.Supplier.ToList();

            var list = from m in _context.Product select m;
            list = list.Where(m => m.CategoryID.Equals(id));
            return View(await list.ToListAsync());
        }
    }
}
