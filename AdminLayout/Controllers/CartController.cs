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
    public class CartController : Controller
    {
        private readonly DPContext _context;

        public CartController(DPContext context)
        {
            _context = context;
        }
        public IActionResult Index()
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
                    return View();
                }
            }
            ViewBag.carts = null;
            ViewBag.listProduct = _context.Product.ToList();
            ViewBag.listProductTop5 = _context.Product.ToList().TakeLast(5);
            ViewBag.listCategory = _context.Category.ToList();
            ViewBag.listSupplier = _context.Supplier.ToList();
            return View();
        }

        public IActionResult CheckoutCart()
        {
            var cart = HttpContext.Session.GetString("cart");
            if (cart != null)
            {
                List<Cart> dataCart = JsonConvert.DeserializeObject<List<Cart>>(cart);
                if (dataCart.Count > 0)
                {
                    ViewBag.carts = dataCart;
                    return View();
                }
            }
            ViewBag.carts = null;
            return View();
        }

        public List<ProductModel> getAllProduct()
        {
            return _context.Product.ToList();
        }

        public ProductModel getDetailProduct(int id)
        {
            var product = _context.Product.Find(id);
            return product;
        }

        public IActionResult addCart(int id)
        {
            var cart = HttpContext.Session.GetString("cart");
            if(cart == null)
            {
                var product = getDetailProduct(id);
                List<Cart> listCart = new List<Cart>()
                {
                    new Cart
                    {
                        Product = product,
                        Quantity = 1
                    }
                };
                HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(listCart));
            }
            else
            {
                List<Cart> dataCart = JsonConvert.DeserializeObject<List<Cart>>(cart);
                bool check = true;
                for(int i =0;i<dataCart.Count; i++)
                {
                    if(dataCart[i].Product.ProductID == id)
                    {
                        dataCart[i].Quantity++;
                        check = false;
                    }
                }
                if(check)
                {
                    dataCart.Add(new Cart
                    {
                        Product = getDetailProduct(id),
                        Quantity = 1
                    });
                }
                HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(dataCart));
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult updateCart(int id, int quantity)
        {
            var cart = HttpContext.Session.GetString("cart");
            if (cart != null)
            {
                List<Cart> dataCart = JsonConvert.DeserializeObject<List<Cart>>(cart);
                if (quantity > 0)
                {
                    for (int i = 0; i < dataCart.Count; i++)
                    {
                        if (dataCart[i].Product.ProductID == id)
                        {
                            dataCart[i].Quantity = quantity;
                        }
                    }
                    HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(dataCart));
                }
                var cart2 = HttpContext.Session.GetString("cart");
                return Ok(quantity);
            }
            return BadRequest();
        }

        public IActionResult deleteCart(int id)
        {
            var cart = HttpContext.Session.GetString("cart");
            if (cart != null)
            {
                List<Cart> dataCart = JsonConvert.DeserializeObject<List<Cart>>(cart);

                for (int i = 0; i < dataCart.Count; i++)
                {
                    if (dataCart[i].Product.ProductID == id)
                    {
                        dataCart.RemoveAt(i);
                    }
                }
                HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(dataCart));
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> createOrder([Bind("Total, CustomerID, Date")] OrderModel orderModel)
        {
            _context.Add(orderModel);
            await _context.SaveChangesAsync();
            HttpContext.Session.Remove("cart");
            return RedirectToAction(actionName: "Index", controllerName: "Home");
        }
    }
}
