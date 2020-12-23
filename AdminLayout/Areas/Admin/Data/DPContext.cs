using AdminLayout.Areas.Admin.Models;
using AdminLayout.Areas.Admin.Models.Configuration;
using AdminLayout.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLayout.Areas.Admin.Data
{
    public class DPContext : IdentityDbContext<User>
    {
        public DPContext(DbContextOptions<DPContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new RoleConfiguration());

        }

        public DbSet<CategoryModel> Categorys { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ProductModel> Products { get; set; }
        public DbSet<SupplierModel> Suppliers { get; set; }
       
        public DbSet<OrderModel> Orders { get; set; }
        public DbSet<OrderDetailModel> OrderDetails { get; set; }
    }
}
