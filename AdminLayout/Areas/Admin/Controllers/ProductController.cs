using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AdminLayout.Areas.Admin.Data;
using AdminLayout.Areas.Admin.Models;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace AdminLayout.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly DPContext _context;

        public ProductController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin/Product
        public async Task<IActionResult> Index()
        {
            var dPContext = _context.Product.Include(p => p.Category).Include(p => p.Supplier);
            return View(await dPContext.ToListAsync());
        }

        // GET: Admin/Product/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productModel = await _context.Product
                .Include(p => p.Category)
                .Include(p => p.Supplier)
                .FirstOrDefaultAsync(m => m.ProductID == id);
            if (productModel == null)
            {
                return NotFound();
            }

            return View(productModel);
        }

        // GET: Admin/Product/Create
        public IActionResult Create()
        {
            ViewData["CategoryID"] = new SelectList(_context.Category, "CategoryID", "CategoryID");
            ViewData["SupplierID"] = new SelectList(_context.Supplier, "SupplierID", "SupplierID");
            ViewBag.ListCategory = _context.Category.ToList();
            ViewBag.ListSupplier = _context.Supplier.ToList();
            return View();
        }

        // POST: Admin/Product/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductID,Img,Name,Price,Content,Status,SupplierID,CategoryID")] ProductModel productModel, IFormFile ful)
        {
            if (ModelState.IsValid)
            {
                _context.Add(productModel);
                await _context.SaveChangesAsync();
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pro", productModel.ProductID + "." + ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1]);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await ful.CopyToAsync(stream);
                }
                productModel.Img = productModel.ProductID + "." + ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1];
                _context.Update(productModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryID"] = new SelectList(_context.Category, "ProductID", "CategoryID", productModel.Category);
            ViewData["SupplierID"] = new SelectList(_context.Supplier, "ProductID", "SupplierID", productModel.Supplier);
            return View(productModel);
        }

        // GET: Admin/Product/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productModel = await _context.Product.FindAsync(id);
            if (productModel == null)
            {
                return NotFound();
            }
            ViewData["CategoryID"] = new SelectList(_context.Category, "CategoryID", "CategoryID", productModel.CategoryID);
            ViewData["SupplierID"] = new SelectList(_context.Supplier, "SupplierID", "SupplierID", productModel.SupplierID);
            ViewBag.ListCategory = _context.Category.ToList();
            ViewBag.ListSupplier = _context.Supplier.ToList();
            return View(productModel);
        }

        // POST: Admin/Product/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProductID,Img,Name,Price,Content,Status,SupplierID,CategoryID")] ProductModel productModel, IFormFile ful)
        {
            if (id != productModel.ProductID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(productModel);
                    if(ful!=null)
                    {
                        var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pro", productModel.Img);
                        System.IO.File.Delete(path);
                        path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pro", productModel.ProductID + "." + ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1]);
                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            await ful.CopyToAsync(stream);
                        }
                        productModel.Img = productModel.ProductID + "." + ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1];
                        _context.Update(productModel);
                    }
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductModelExists(productModel.ProductID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryID"] = new SelectList(_context.Category, "CategoryID", "CategoryID", productModel.Category);
            ViewData["SupplierID"] = new SelectList(_context.Supplier, "SupplierID", "SupplierID", productModel.Supplier);
            return View(productModel);
        }

        // GET: Admin/Product/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productModel = await _context.Product
                .Include(p => p.Category)
                .Include(p => p.Supplier)
                .FirstOrDefaultAsync(m => m.ProductID == id);
            if (productModel == null)
            {
                return NotFound();
            }

            return View(productModel);
        }

        // POST: Admin/Product/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var productModel = await _context.Product.FindAsync(id);
            _context.Product.Remove(productModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductModelExists(int id)
        {
            return _context.Product.Any(e => e.ProductID == id);
        }
    }
}
