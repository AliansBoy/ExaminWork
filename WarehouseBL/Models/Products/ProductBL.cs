using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseBL.Models.Customer;
using WarehouseBL.Models.Provider;

namespace WarehouseBL.Models.Products
{
    public class ProductBL : BaseModelBL
    {
        public string Manufacturer { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }
        public int CountryId { get; set; }
        public int ProductGroupId { get; set; }

        public CountryBL Country { get; set; }
        public ProductGroupBL ProductGroup { get; set; }
        public IEnumerable<ProductDeliveryBL> ProductDeliveries { get; set; }
        public IEnumerable<ProductShipmentBL> ProductShipments { get; set; }
    }
}
