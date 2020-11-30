using AdminLayout.Areas.Admin.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLayout.Areas.Admin.Data
{
    public class DPContext : DbContext
    {
        public DPContext(DbContextOptions<DPContext> options) : base(options)
        {

        }

        public DbSet<CategoryModel> Category { get; set; }
        public DbSet<ProductModel> Product { get; set; }
        public DbSet<SupplierModel> Supplier { get; set; }
        public DbSet<CustomerModel> Customer { get; set; }
        public DbSet<AdminModel> Admin { get; set; }
        public DbSet<OrderModel> Order { get; set; }
        public DbSet<OrderDetailModel> OrderDetail { get; set; }
    }
}
