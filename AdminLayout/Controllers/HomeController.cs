using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AdminLayout.Models;
using AdminLayout.Areas.Admin.Data;
using AdminLayout.Areas.Admin.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;

namespace AdminLayout.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly DPContext _context;

        public HomeController(DPContext context)
        {
            _context = context;
        }

        void Application_Error(object sender, EventArgs e)
        {
            
        }
        //public IActionResult Login(string Email, string Pass)
        //{
        //    if (!String.IsNullOrEmpty(Email) && !String.IsNullOrEmpty(Pass))
        //    {
        //        var custom = from c in _context.Customer
        //                     where c.Email == Email && c.Password == Pass
        //                     select new { c.Name };
        //        //var user =  _context.Customer
        //        //.FirstOrDefaultAsync(m => m.Email == Email &&  m.Password == Pass);
        //        return View("Index",custom);
        //    }
        //    else
        //    {
        //        return NotFound();
        //    }
        //}
        //public IActionResult Index(string? name)
        //public IActionResult Login(string Email, string Pass)
        //{
        //    //1. Tạo danh sách danh mục để hiển thị ở giao diện View thông qua DropDownList
        //    //var loai = from c in _context.LoaiSP select c;
        //    //ViewBag.Loai = new SelectList(loai, "Id", "Name"); // danh sách Loại SP

        //    //2. Tạo câu truy vấn kết 2 bảng bằng mệnh đề join
        //    //var sp = from l in _context.LoaiSP
        //    //         join c in _context.SanPham on l.Id equals c.MaLoai
        //    //         select new { l.Name, c.ProName, c.MaLoai, c.Loai, c.Img, c.Id };
        //    var custom = from c in _context.Customer
        //                 select new { c.Name, c.Email, c.Password };


        //    //3. Tìm kiếm chuỗi truy vấn
        //    if (!String.IsNullOrEmpty(Email) && !String.IsNullOrEmpty(Pass))
        //    {
        //        custom = custom.Where(s => s.Email.Contains(Email));
        //        custom = custom.Where(y => y.Password.Contains(Pass));
        //        return View();
        //    }
        //    else
        //    {
        //        ModelState.AddModelError(string.Empty, "Invalid login attempt.");
        //        return NotFound();
        //    }
        //    //5. Chuyển đổi kết quả từ var sang danh sách List<Link>
        //     //trả về kết quả
        //}

        public async Task<IActionResult> Index()
        {
            //ViewBag.USer = name;
            return View();
        }

        public async Task<IActionResult> Test()
        {
            DateTime now = DateTime.Now;
            return Json("Time: "+ now );
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
