using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Models.Provider
{
    public class ProviderViewModel
    {
        public string Id { get; set; }
        public string OrganizationName { get; set; }
        public string Address { get; set; }
        public string ResponsiblePerson { get; set; }
        public string Position { get; set; }


        public IEnumerable<DeliveryViewModel> Deliveries { get; set; }
    }
}
