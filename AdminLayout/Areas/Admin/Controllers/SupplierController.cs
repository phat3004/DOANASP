using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AdminLayout.Areas.Admin.Data;
using AdminLayout.Areas.Admin.Models;

namespace AdminLayout.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SupplierController : Controller
    {
        private readonly DPContext _context;

        public SupplierController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin/Supplier
        public async Task<IActionResult> Index()
        {
            return View(await _context.Supplier.ToListAsync());
        }

        // GET: Admin/Supplier/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var supplierModel = await _context.Supplier
                .FirstOrDefaultAsync(m => m.SupplierID == id);
            if (supplierModel == null)
            {
                return NotFound();
            }

            return View(supplierModel);
        }

        // GET: Admin/Supplier/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Supplier/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SupplierID,Name,Img,Address,Phone")] SupplierModel supplierModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(supplierModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(supplierModel);
        }

        // GET: Admin/Supplier/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var supplierModel = await _context.Supplier.FindAsync(id);
            if (supplierModel == null)
            {
                return NotFound();
            }
            return View(supplierModel);
        }

        // POST: Admin/Supplier/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SupplierID,Name,Img,Address,Phone")] SupplierModel supplierModel)
        {
            if (id != supplierModel.SupplierID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(supplierModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SupplierModelExists(supplierModel.SupplierID))
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
            return View(supplierModel);
        }

        // GET: Admin/Supplier/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var supplierModel = await _context.Supplier
                .FirstOrDefaultAsync(m => m.SupplierID == id);
            if (supplierModel == null)
            {
                return NotFound();
            }

            return View(supplierModel);
        }

        // POST: Admin/Supplier/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var supplierModel = await _context.Supplier.FindAsync(id);
            _context.Supplier.Remove(supplierModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SupplierModelExists(int id)
        {
            return _context.Supplier.Any(e => e.SupplierID == id);
        }
    }
}
