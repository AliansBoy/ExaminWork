using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseDAL.Entities
{
    public class Country : BaseEntity<int>
    {
        #region Scalar Prooerties
        public string Name { get; set; }
        #endregion

        #region Navigation Properties
        public virtual ICollection<Product> Products { get; set; }
        #endregion
    }
}
