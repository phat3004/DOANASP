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
    public class UserInfoAPIController : ControllerBase
    {
        private readonly DPContext _context;

        public UserInfoAPIController(DPContext context)
        {
            _context = context;  
        }
        // GET: api/<UserInfoAPIController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet]
        public string GetUserLoginInfo()
        {
            var listUserlogin = _context.Users;
            var listNewUserLogin = from p in _context.Users
                                   select p;
            return JsonConvert.SerializeObject(listNewUserLogin);
        }

        [HttpGet]
        public string GetUserIsLogging(string mail)
        {
            var user = from m in _context.User.Where(m => m.Email == mail)
                       select m;
            return JsonConvert.SerializeObject(user);
        }

        // GET api/<UserInfoAPIController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UserInfoAPIController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UserInfoAPIController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserInfoAPIController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
