using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLayout.Areas.Admin.Models
{
    public class OrderDetailModel
    {
        [Key]
        public int ID { get; set; }
        public int OrderID { get; set; }
        [ForeignKey("OrderID")]
        public int ProductID { get; set; }
        [ForeignKey("ProductID")]
        public string Name { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public virtual OrderModel Order { get; set; }
        public virtual ProductModel Product { get; set; }
    }
}
