using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Models.Customer;
using Warehouse.Models.Provider;

namespace Warehouse.Models.Employee
{
    public class EmployeeRegisterModel : RegisterViewModel
    {
        public string UserId { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3)]
        [Display(Name = "Second Name")]
        public string SecondName { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 6)]
        [DataType(DataType.Date)]
        [Display(Name = "Date Born")]
        public DateTime? DateBorn { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 6)]
        [Display(Name = "Address")]
        public string Address { get; set; }

        public IEnumerable<DeliveryViewModel> Deliveries { get; set; }
        public IEnumerable<ShipmentViewModel> Shipments { get; set; }
    }
}
