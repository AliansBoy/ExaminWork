using System;
using System.Collections.Generic;

namespace WarehouseDAL.Entities
{
    public class Shipment : BaseEntity<int>
    {
        #region Scalar Prooerties
        public string CustomerId { get; set; }
        public string EmployeeId { get; set; }
        public DateTime? DeliveryDate { get; set; }
        #endregion

        #region Navigation Properties
        public virtual Customer Customer { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual ICollection<ProductShipment> ProductShipments { get; set; } 
        #endregion
    }
}