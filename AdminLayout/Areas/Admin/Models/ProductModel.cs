using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLayout.Areas.Admin.Models
{
    public class ProductModel
    {
        [Key]
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Content { get; set; }
        public int Status { get; set; }
        public string Img { get; set; }
        public int SupplierID { get; set; }
        [ForeignKey("SupplierID")]
        public int CategoryID { get; set; }
        [ForeignKey("CategoryID")]

        public virtual CategoryModel Category { get; set; }
        public virtual SupplierModel Supplier { get; set; }
    }
}
