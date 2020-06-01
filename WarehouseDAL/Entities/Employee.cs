using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseDAL.Entities
{
    public class Employee
    {
        #region Scalar Prooerties
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public DateTime? DateBorn { get; set; }
        public string ContactPerson { get; set; }
        public string Address { get; set; }
        #endregion

        #region Navigation Properties
        public virtual ICollection<Delivery> Deliveries { get; set; }
        public virtual ICollection<Shipment> Shipments { get; set; }
        #endregion
    }
}
