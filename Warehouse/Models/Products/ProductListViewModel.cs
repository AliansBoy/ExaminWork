using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Warehouse.HtmlHelpers;

namespace Warehouse.Models.Products
{
    public class ProductListViewModel
    {
        public IEnumerable<ProductViewModel> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public int CurrentCateogry { get; set; }
    }
}