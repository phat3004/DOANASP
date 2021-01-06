using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminLayout.Areas.Admin.Data;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AdminLayout.Areas.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class GetAPIController : ControllerBase
    {
        private readonly DPContext _context;

        public GetAPIController(DPContext context)
        {
            _context = context;
        }
            // GET: api/<GetAPIController>
            [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        [HttpGet]
        public string GetProduct()
        {
            var listProduct = _context.Products;
            var listNewProduct = from p in _context.Products
                                   select new {p.Name,p.Price,p.Img,p.Quantity,p.Status,p.Content,namecategory = p.Category.Name, namesuplier = p.Supplier.Name};
            return JsonConvert.SerializeObject(listNewProduct);
        }
        [HttpGet]
        public string GetSupplier()
        {
            var listsup = _context.Suppliers;
            var listnewsup = from p in _context.Suppliers
                             select p;
            return JsonConvert.SerializeObject(listnewsup);
        }
        // GET api/<GetAPIController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<GetAPIController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<GetAPIController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<GetAPIController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
