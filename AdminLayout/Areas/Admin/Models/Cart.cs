using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLayout.Areas.Admin.Models
{
    public class Cart
    {
        public ProductModel Product { get; set; }
        public int Quantity { get; set; }
    }
}
