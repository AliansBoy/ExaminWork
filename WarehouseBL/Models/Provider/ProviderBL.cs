using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseBL.Models.Provider
{
    public class ProviderBL
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string OrganizationName { get; set; }
        public string Address { get; set; }
        public string ContactPerson { get; set; }
        public string Position { get; set; }

        public IEnumerable<DeliveryBL> Deliveries { get; set; }
    }
}
