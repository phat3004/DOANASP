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
    public class PostModelController : Controller
    {
        private readonly DPContext _context;

        public PostModelController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin/PostModel
        public async Task<IActionResult> Index()
        {
            var dPContext = _context.Post.Include(p => p.Category);
            return View(await dPContext.ToListAsync());
        }

        // GET: Admin/PostModel/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var postModel = await _context.Post
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.IDPost == id);
            if (postModel == null)
            {
                return NotFound();
            }

            return View(postModel);
        }

        // GET: Admin/PostModel/Create
        public IActionResult Create()
        {
            ViewData["CategoryID"] = new SelectList(_context.Category, "IDCategory", "IDCategory");
            return View();
        }

        // POST: Admin/PostModel/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDPost,Img,Title,Description,Content,Author,CategoryID")] PostModel postModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(postModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryID"] = new SelectList(_context.Category, "IDCategory", "IDCategory", postModel.CategoryID);
            return View(postModel);
        }

        // GET: Admin/PostModel/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var postModel = await _context.Post.FindAsync(id);
            if (postModel == null)
            {
                return NotFound();
            }
            ViewData["CategoryID"] = new SelectList(_context.Category, "IDCategory", "IDCategory", postModel.CategoryID);
            return View(postModel);
        }

        // POST: Admin/PostModel/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IDPost,Img,Title,Description,Content,Author,CategoryID")] PostModel postModel)
        {
            if (id != postModel.IDPost)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(postModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PostModelExists(postModel.IDPost))
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
            ViewData["CategoryID"] = new SelectList(_context.Category, "IDCategory", "IDCategory", postModel.CategoryID);
            return View(postModel);
        }

        // GET: Admin/PostModel/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var postModel = await _context.Post
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.IDPost == id);
            if (postModel == null)
            {
                return NotFound();
            }

            return View(postModel);
        }

        // POST: Admin/PostModel/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var postModel = await _context.Post.FindAsync(id);
            _context.Post.Remove(postModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PostModelExists(int id)
        {
            return _context.Post.Any(e => e.IDPost == id);
        }
    }
}
