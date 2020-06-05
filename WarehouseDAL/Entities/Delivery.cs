using System;
using System.Collections.Generic;

namespace WarehouseDAL.Entities
{
    public class Delivery : BaseEntity<int>
    {
        #region Scalar Prooerties
        public string ProviderId { get; set; }
        public string EmployeeId { get; set; }
        public DateTime? DeliveryDate { get; set; }
        #endregion

        #region Navigation Properties
        public virtual Provider Provider { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual ICollection<ProductDelivery> ProductDeliveries { get; set; }
        #endregion
    }
}