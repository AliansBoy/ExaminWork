using System.Collections.Generic;

namespace Warehouse.Models.Products
{
    public class ProductGroupViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Descriprion { get; set; }

        public IEnumerable<ProductViewModel> Products { get; set; }
    }
}