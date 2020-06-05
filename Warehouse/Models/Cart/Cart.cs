using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseBL.Models.Products;

namespace Warehouse.Models.Cart
{
    public class CartLine
    {
        public ProductBL Product { get; set; }
        public int Quantity { get; set; }
    }

    public class Cart
    {
        private List<CartLine> lineCollection = new List<CartLine>();

        public void AddItem(ProductBL product, int quantity)
        {
            CartLine line = lineCollection.FirstOrDefault(p => p.Product.Id == product.Id);

            if (line == null)
            {
                lineCollection.Add(new CartLine { Product = product, Quantity = quantity });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        public void RemoveLine(ProductBL product)
        {
            lineCollection.RemoveAll(p => p.Product.Id == product.Id);
        }

        public decimal ComputeTotalValue()
        {
            return (lineCollection.Sum(e => e.Product.Price * e.Quantity));
        }

        public void Clear()
        {
            lineCollection.Clear();
        }

        public IEnumerable<CartLine> Lines
        {
            get { return lineCollection; }
        }
    }
}
