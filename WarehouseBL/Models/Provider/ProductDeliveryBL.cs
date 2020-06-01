using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseBL.Models.Products;

namespace WarehouseBL.Models.Provider
{
    public class ProductDeliveryBL : BaseModelBL
    {
        public int ProductId { get; set; }
        public int DeliveryId { get; set; }
        public int Amount { get; set; }

        public ProductBL Product { get; set; }
        public DeliveryBL Delivery { get; set; }
    }
}
