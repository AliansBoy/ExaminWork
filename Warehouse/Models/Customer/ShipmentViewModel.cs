using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Models.Employee;

namespace Warehouse.Models.Customer
{
    public class ShipmentViewModel
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime? DeliveryDate { get; set; }

        public CustomerViewModel Customer { get; set; }
        public EmployeeViewModel Employee { get; set; }
        public IEnumerable<ProductShipmentViewModel> ProductShipments { get; set; }
    }
}
