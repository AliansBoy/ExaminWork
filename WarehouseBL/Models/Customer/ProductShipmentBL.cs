using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseBL.Models.Products;

namespace WarehouseBL.Models.Customer
{
    public class ProductShipmentBL : BaseModelBL
    {
        public int ProductId { get; set; }
        public int DeliveryId { get; set; }
        public int Amount { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }

        public ShipmentBL Shipment { get; set; }
        public ProductBL Product { get; set; }
    }
}
