using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Warehouse.Models.Customer;
using Warehouse.Models.Provider;

namespace Warehouse.Models.Products
{
    public class ProductViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Manufacturer")]
        public string Manufacturer { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Price")]
        public int Price { get; set; }

        [Required]
        [Display(Name = "Amount")]
        public int Amount { get; set; }

        [DataType(DataType.ImageUrl)]
        [Display(Name = "Image")]
        public string Image { get; set; }

        [Required]
        [Display(Name = "CountryId")]
        public int CountryId { get; set; }

        [Required]
        [Display(Name = "ProductGroupId")]
        public int ProductGroupId { get; set; }

        public HttpPostedFileBase ImageFile { get; set; }


        public CountryViewModel Country { get; set; }
        public ProductGroupViewModel ProductGroup { get; set; }
        public IEnumerable<ProductDeliveryViewModel> ProductDeliveries { get; set; }
        public IEnumerable<ProductShipmentViewModel> ProductShipments { get; set; }
    }
}
