using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminLayout.Areas.Admin.Data;
using Microsoft.AspNetCore.Mvc;

namespace AdminLayout.Controllers
{
    public class SupplierController : Controller
    {
        private readonly DPContext _context;

        public SupplierController(DPContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.listPost = _context.Product.ToList();
            ViewBag.listCategory = _context.Category.ToList();
            ViewBag.listSupplier = _context.Supplier.ToList();
            return View();
        }
    }
}
