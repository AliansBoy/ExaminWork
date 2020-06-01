using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseDAL.Entities
{
    public class ProductShipment : BaseEntity<int>
    {
        #region Field
        private Product _product;
        #endregion

        #region Scalar Prooerties
        public int ProductId { get; set; }
        public int DeliveryId { get; set; }
        public int Amount { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
        #endregion

        #region Navigation Properties
        public virtual Shipment Shipment { get; set; }
        public virtual Product Product
        {
            get { return _product;}
            set 
            {
                _product = value;
                UnitPrice = value.Price;
                TotalPrice = UnitPrice * Amount;
            } 
        }
        #endregion

    }
}
