using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseBL.Models.Products;

namespace WarehouseBL.Interfaces
{
    public interface IProductService : IGenericService<ProductBL>
    {
        IEnumerable<ProductBL> AllIncluding();
        IEnumerable<ProductBL> Where(int category, int page, int pageSize);
    }
}
