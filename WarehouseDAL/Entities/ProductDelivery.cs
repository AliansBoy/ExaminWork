using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseDAL.Entities
{
    public class ProductDelivery : BaseEntity<int>
    {
        #region Scalar Prooerties
        public int ProductId { get; set; }
        public int DeliveryId { get; set; }
        public int Amount { get; set; }
        #endregion

        #region Navigation Properties
        public virtual Product Product { get; set; }
        public virtual Delivery Delivery { get; set; }
        #endregion
    }
}
