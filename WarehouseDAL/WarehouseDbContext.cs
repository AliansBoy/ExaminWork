using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseDAL.Entities;

namespace WarehouseDAL
{
    public class WarehouseDbContext : DbContext
    {
        static WarehouseDbContext()
        {
            Database.SetInitializer<WarehouseDbContext>(new WarehouseDbInitializer());
        }
        public WarehouseDbContext() : base(nameof(WarehouseDbContext)) { }

        public static WarehouseDbContext Create()
        {
            return new WarehouseDbContext();
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDelivery> ProductDeliveries { get; set; }
        public DbSet<ProductShipment> ProductShipments { get; set; }
        public DbSet<ProductGroup> ProductGroups { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Shipment> Shipments { get; set; }
    }
}
