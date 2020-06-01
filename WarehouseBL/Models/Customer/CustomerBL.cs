using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseBL.Models.Customer
{
    public class CustomerBL
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public bool IsCanOrder { get; set; }
        public string OrganizationName { get; set; }
        public string Address { get; set; }
        public string ResponsiblePerson { get; set; }
        public string Position { get; set; }

        public IEnumerable<ShipmentBL> Shipments { get; set; }
    }
}
