using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseDAL.Entities;

namespace WarehouseDAL
{
    public class WarehouseDbInitializer : DropCreateDatabaseAlways<WarehouseDbContext>
    {
        protected override void Seed(WarehouseDbContext db)
        {
            #region Country
            Country country1 = new Country { Name = "Poland" };
            Country country2 = new Country { Name = "Ukraine" };
            Country country3 = new Country { Name = "China" };

            db.Countries.Add(country1);
            db.Countries.Add(country2);
            db.Countries.Add(country3);
            db.SaveChanges();
            #endregion

            #region ProductGroup
            ProductGroup group1 = new ProductGroup { Name = "Spray", Descriprion = "Aerosol enamel" };
            ProductGroup group2 = new ProductGroup { Name = "Blander", Descriprion = "electric mixing machine used in food preparation" };
            ProductGroup group3 = new ProductGroup { Name = "Slow cooker", Descriprion = " large electric pot used for cooking food" };

            db.ProductGroups.Add(group1);
            db.ProductGroups.Add(group2);
            db.ProductGroups.Add(group3);
            db.SaveChanges();
            #endregion

            #region Product
            Product product1 = new Product { Manufacturer = "NewTon", Title = "RAL 5010", ProductGroupId = 1,
                CountryId = 2, Price = 60.5M, Amount = 10, Image = "~/Image/5010standartsinaya.png"};
            Product product2 = new Product { Manufacturer = "NewTon", Title = "RAL 1015", ProductGroupId = 1, 
                CountryId = 2, Price = 60.5M, Amount = 15, Image = "~/Image/1015slonovakost.png" };
            Product product3 = new Product { Manufacturer = "NewTon", Title = "RAL 2004", ProductGroupId = 1, 
                CountryId = 2, Price = 60.5M, Amount = 7, Image = "~/Image/2004orange.png" };
            Product product4 = new Product { Manufacturer = "NewTon", Title = "RAL 4003", ProductGroupId = 1, 
                CountryId = 2, Price = 60.5M, Amount = 5, Image = "~/Image/4003rozova.png" };
            Product product5 = new Product { Manufacturer = "NewTon", Title = "RAL 5022", ProductGroupId = 1, 
                CountryId = 2, Price = 60.5M, Amount = 19, Image = "~/Image/5022temnosinaya.png" };
            Product product6 = new Product { Manufacturer = "NewTon", Title = "RAL 6029", ProductGroupId = 1, 
                CountryId = 2, Price = 60.5M, Amount = 2, Image = "~/Image/6029zelenaya.png" };
            Product product7 = new Product { Manufacturer = "NewTon", Title = "RAL 8011", ProductGroupId = 1, 
                CountryId = 2, Price = 60.5M, Amount = 10, Image = "~/Image/8011korich.png" };
            Product product8 = new Product { Manufacturer = "NewTon", Title = "RAL 8017", ProductGroupId = 1, 
                CountryId = 2, Price = 60.5M, Amount = 15, Image = "~/Image/8017temno-korich.png" };
            Product product9 = new Product { Manufacturer = "Champion", Title = "Ceramix", ProductGroupId = 1, 
                CountryId = 2, Price = 80, Amount = 17, Image = "~/Image/Ceramix.jpg" };
            Product product10 = new Product { Manufacturer = "Champion", Title = "RAL 9003", ProductGroupId = 1, 
                CountryId = 2, Price = 65, Amount = 10, Image = "~/Image/RAL_9003_White.jpg" };
            Product product11 = new Product { Manufacturer = "Rotex", Title = "RMC-401-B", ProductGroupId = 3,
                CountryId = 2, Price = 750.6M, Amount = 12, Image = "~/Image/Rotex_Rmc401-B.jpg" };
            Product product12 = new Product { Manufacturer = "Rotex", Title = "RMC-507-B", ProductGroupId = 3, 
                CountryId = 2, Price = 820, Amount = 20, Image = "~/Image/Rotex_Rmc507-B.jpg" };
            Product product13 = new Product { Manufacturer = "Rotex", Title = "RMC-522-G", ProductGroupId = 3, 
                CountryId = 2, Price = 1020, Amount = 20, Image = "~/Image/rotex_rmc522_g.jpg" };
            Product product14 = new Product { Manufacturer = "Rotex", Title = "RTB-504-W", ProductGroupId = 2,
                CountryId = 2, Price = 790, Amount = 15, Image = "~/Image/rotex_rtb504_w.jpg" };
            Product product15 = new Product { Manufacturer = "Rotex", Title = "RTB-505-W", ProductGroupId = 2, 
                CountryId = 2, Price = 810, Amount = 8, Image = "~/Image/rotex_rtb505_w.jpg" };
            Product product16 = new Product { Manufacturer = "Rotex", Title = "RTB-740-B", ProductGroupId = 2, 
                CountryId = 2, Price = 980.5M, Amount = 10, Image = "~/Image/rotex_rtb740-b.jpg" };

            db.Products.Add(product1);
            db.Products.Add(product2);
            db.Products.Add(product3);
            db.Products.Add(product4);
            db.Products.Add(product5);
            db.Products.Add(product6);
            db.Products.Add(product7);
            db.Products.Add(product8);
            db.Products.Add(product9);
            db.Products.Add(product10);
            db.Products.Add(product11);
            db.Products.Add(product12);
            db.Products.Add(product13);
            db.Products.Add(product14);
            db.Products.Add(product15);
            db.Products.Add(product16);
            db.SaveChanges();

            #endregion
        }
    }
}
