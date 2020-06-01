using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Models.Products;

namespace Warehouse.Models.Provider
{
    public class ProductDeliveryViewModel
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int DeliveryId { get; set; }
        public int Amount { get; set; }

        public ProductViewModel Product { get; set; }
        public DeliveryViewModel Delivery { get; set; }
    }
}
