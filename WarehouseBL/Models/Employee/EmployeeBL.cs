using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseBL.Models.Customer;
using WarehouseBL.Models.Provider;

namespace WarehouseBL.Models.Employee
{
    public class EmployeeBL
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public DateTime? DateBorn { get; set; }
        public string Address { get; set; }

        public IEnumerable<DeliveryBL> Deliveries { get; set; }
        public IEnumerable<ShipmentBL> Shipments { get; set; }
    }
}
