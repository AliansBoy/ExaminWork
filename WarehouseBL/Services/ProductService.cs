using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseBL.Interfaces;
using WarehouseBL.Models.Products;
using WarehouseDAL.Entities;
using WarehouseDAL.Interfaces;

namespace WarehouseBL.Services
{
    public class ProductService : GenericService<ProductBL, Product>, IProductService
    {
        private IMapper _mapper;
        public ProductService(IGenericRepository<Product> repository, IMapper mapper) : base(repository)
        {
            _mapper = mapper;
        }
        public override ProductBL Map(Product entity)
        {
            return _mapper.Map<ProductBL>(entity);
        }

        public override Product Map(ProductBL blmodel)
        {
            return _mapper.Map<Product>(blmodel);
        }

        public override IEnumerable<ProductBL> Map(IList<Product> entities)
        {
            return _mapper.Map<IEnumerable<ProductBL>>(entities);
        }

        public override IEnumerable<Product> Map(IList<ProductBL> models)
        {
            return _mapper.Map<IEnumerable<Product>>(models);
        }
    }
}
