using ActuallEntityTest.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ActuallEntityTest.Shared {
    public class AppDbContext : DbContext {
        public DbSet<CustomerModel> Customers { get; set; }
        public DbSet<OrderModel> Orders { get; set; }
        public DbSet<ProductModel> Products { get; set; }
        public DbSet<ProductOrderModel> ProductOrders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer("Server=tcp:krissl1.database.windows.net,1433;Initial Catalog=Espen;Persist Security Info=False;User ID=PushedMaster;Password=FakeTaxi123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }

    }
}
