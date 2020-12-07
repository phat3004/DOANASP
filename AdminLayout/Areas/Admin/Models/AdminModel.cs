using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLayout.Areas.Admin.Models
{
    public class AdminModel
    {
        [Key]
        public int AdminID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public int PhoneNumber { get; set; }
        public string Img { get; set; }
        public bool Status { get; set; }
    }
}
