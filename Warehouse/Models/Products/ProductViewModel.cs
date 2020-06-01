using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Models.Customer;
using Warehouse.Models.Provider;

namespace Warehouse.Models.Products
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }
        public int CountryId { get; set; }
        public int ProductGroupId { get; set; }

        public CountryViewModel Country { get; set; }
        public ProductGroupViewModel ProductGroup { get; set; }
        public IEnumerable<ProductDeliveryViewModel> ProductDeliveries { get; set; }
        public IEnumerable<ProductShipmentViewModel> ProductShipments { get; set; }
    }
}
