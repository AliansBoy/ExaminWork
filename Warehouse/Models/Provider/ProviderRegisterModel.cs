using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Models.Provider
{
    public class ProviderRegisterModel : RegisterViewModel
    {
        public string UserId { get; set; }
        public string OrganizationName { get; set; }
        public string Address { get; set; }
        public string ContactPerson { get; set; }
        public string Position { get; set; }

        public IEnumerable<DeliveryViewModel> Deliveries { get; set; }
    }
}
