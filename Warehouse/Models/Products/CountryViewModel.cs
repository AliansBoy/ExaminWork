using System.Collections.Generic;

namespace Warehouse.Models.Products
{
    public class CountryViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IEnumerable<ProductViewModel> Products { get; set; }
    }
}