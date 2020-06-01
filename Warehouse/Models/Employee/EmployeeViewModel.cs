using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Models.Customer;
using Warehouse.Models.Provider;

namespace Warehouse.Models.Employee
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public DateTime? DateBorn { get; set; }
        public string Position { get; set; }
        public string Address { get; set; }

        public IEnumerable<DeliveryViewModel> Deliveries { get; set; }
        public IEnumerable<ShipmentViewModel> Shipments { get; set; }
    }
}
