using System.Collections.Generic;

namespace WarehouseBL.Models.Products
{
    public class CountryBL : BaseModelBL
    {
        public string Name { get; set; }

        public IEnumerable<ProductBL> Products { get; set; }
    }
}