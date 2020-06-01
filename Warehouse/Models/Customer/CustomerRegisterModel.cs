using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Warehouse.Models.Customer
{
    public class CustomerRegisterModel : RegisterViewModel
    {
        public string UserId { get; set; }
        public bool IsCanOrder { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Organization Name")]
        public string OrganizationName { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 6)]
        [Display(Name = "Address")]
        public string Address { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 6)]
        [Display(Name = "Responsible Person Name")]
        public string ResponsiblePerson { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 2)]
        [Display(Name = "Position")]
        public string Position { get; set; }
    }
}