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
        private IGenericRepository<Product> _repository;
        private IMapper _mapper;
        public ProductService(IGenericRepository<Product> repository, IMapper mapper) : base(repository)
        {
            _mapper = mapper;
            _repository = repository;
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

        public IEnumerable<ProductBL> AllIncluding()
        {
            var products = _repository.AllIncluding(p => p.ProductGroup, p => p.Country).ToList();
            return Map(products);
        }

        public IEnumerable<ProductBL> Where(int category,int page, int pageSize)
        {
            var products = _repository.GetAll();
            var productsSort = products.Where(p => category == 0 || p.ProductGroup.Id == category)
                                                .OrderBy(p => p.Id)
                                                .Skip((page - 1) * pageSize)
                                                .Take(pageSize).ToList();
            return Map(productsSort);
        }
    }
}
