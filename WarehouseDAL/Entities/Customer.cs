using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseDAL.Entities
{
    public class Customer
    {
        #region Scalar Prooerties
        [Key]
        public string Id { get; set; }
        public bool IsCanOrder { get; set; }
        public string OrganizationName { get; set; }
        public string Address { get; set; }
        public string ResponsiblePerson { get; set; }
        public string Position { get; set; }
        #endregion

        #region Navigation Properties
        public virtual ICollection<Shipment> Shipments { get; set; }
        #endregion
    }
}
