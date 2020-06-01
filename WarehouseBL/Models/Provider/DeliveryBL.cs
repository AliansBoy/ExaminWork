using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseBL.Models.Employee;

namespace WarehouseBL.Models.Provider
{
    public class DeliveryBL : BaseModelBL
    {
        public int ProviderId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime? DeliveryDate { get; set; }

        public ProviderBL Provider { get; set; }
        public EmployeeBL Employee { get; set; }
        public IEnumerable<ProductDeliveryBL> ProductDeliveries { get; set; }
    }
}
