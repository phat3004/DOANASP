﻿using System;
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
    public class CategoryController : Controller
    {
        private readonly DPContext _context;

        public CategoryController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin/Category
        public async Task<IActionResult> Index()
        {
            return View(await _context.Categorys.ToListAsync());
        }

        // GET: Admin/Category/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoryModel = await _context.Categorys
                .FirstOrDefaultAsync(m => m.CategoryID == id);
            if (categoryModel == null)
            {
                return NotFound();
            }

            return View(categoryModel);
        }

        // GET: Admin/Category/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Category/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CategoryID,Name")] CategoryModel categoryModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(categoryModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(categoryModel);
        }

        // GET: Admin/Category/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoryModel = await _context.Categorys.FindAsync(id);
            if (categoryModel == null)
            {
                return NotFound();
            }
            return View(categoryModel);
        }

        // POST: Admin/Category/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CategoryID,Name")] CategoryModel categoryModel)
        {
            if (id != categoryModel.CategoryID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(categoryModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoryModelExists(categoryModel.CategoryID))
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
            return View(categoryModel);
        }

        // GET: Admin/Category/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoryModel = await _context.Categorys
                .FirstOrDefaultAsync(m => m.CategoryID == id);
            if (categoryModel == null)
            {
                return NotFound();
            }

            return View(categoryModel);
        }

        // POST: Admin/Category/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var categoryModel = await _context.Categorys.FindAsync(id);
            _context.Categorys.Remove(categoryModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CategoryModelExists(int id)
        {
            return _context.Categorys.Any(e => e.CategoryID == id);
        }
    }
}
