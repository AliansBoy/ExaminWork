using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Models.Employee;

namespace Warehouse.Models.Provider
{
    public class DeliveryViewModel
    {
        public int Id { get; set; }
        public string ProviderId { get; set; }
        public string EmployeeId { get; set; }
        public DateTime? DeliveryDate { get; set; }

        public ProviderViewModel Provider { get; set; }
        public EmployeeViewModel Employee { get; set; }
        public IEnumerable<ProductDeliveryViewModel> ProductDeliveries { get; set; }
    }
}
