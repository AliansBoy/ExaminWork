using System.Collections;
using System.Collections.Generic;

namespace WarehouseDAL.Entities
{
    public class ProductGroup : BaseEntity<int>
    {
        #region Scalar Prooerties
        public string Name { get; set; }
        public string Descriprion { get; set; }
        #endregion

        #region Navigation Properties
        public virtual ICollection<Product> Products { get; set; }
        #endregion
    }
}