using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminLayout.Areas.Admin.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
            ViewBag.listProductTop5 = _context.Product.ToList().TakeLast(5);
            ViewBag.listCategory = _context.Category.ToList();
            ViewBag.listSupplier = _context.Supplier.ToList();

            if (id == null)
            {
                return NotFound();
            }

            var postModel = await _context.Product
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.ProductID == id);
            if (postModel == null)
            {
                return NotFound();
            }

            return View(postModel);
        }
    }
}
