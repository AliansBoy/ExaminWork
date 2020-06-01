using System.Collections.Generic;

namespace WarehouseBL.Models.Products
{
    public class ProductGroupBL : BaseModelBL
    {
        public string Name { get; set; }
        public string Descriprion { get; set; }

        public IEnumerable<ProductBL> Products { get; set; }
    }
}