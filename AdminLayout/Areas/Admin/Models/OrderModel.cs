using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLayout.Areas.Admin.Models
{
    public class OrderModel
    {
        [Key]
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        [ForeignKey("CustomerID")]
        public Decimal Total { get; set; }
        public DateTime Date { get; set; }
        public virtual User Users { get; set; }
    }
}
