using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace AdminLayout.Areas.Admin.Models
{
    public class SupplierModel
    {
        [Key]
        public int SupplierID { get; set; }
        public string Name { get; set; }
        public string Img { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }
        public ICollection<ProductModel> listProduct { get; set; }
    }
}
