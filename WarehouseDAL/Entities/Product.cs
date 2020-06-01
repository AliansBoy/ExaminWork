using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseDAL.Entities
{
    public class Product : BaseEntity<int>
    {
        #region Scalar Properties
        public string Manufacturer { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }
        public int CountryId { get; set; }
        public int ProductGroupId { get; set; }
        #endregion

        #region Navigation Properties
        public virtual Country Country { get; set; }
        public virtual ProductGroup ProductGroup { get; set; }
        public virtual ICollection<ProductDelivery> ProductDeliveries { get; set; }
        public virtual ICollection<ProductShipment> ProductShipments { get; set; }
        #endregion
    }
}
