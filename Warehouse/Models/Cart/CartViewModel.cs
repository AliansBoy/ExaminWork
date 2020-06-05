using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Warehouse.Models.Products;
using WarehouseBL.Interfaces;

namespace Warehouse.Models.Cart
{
    public class CartViewModel
    {
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }
    }
}