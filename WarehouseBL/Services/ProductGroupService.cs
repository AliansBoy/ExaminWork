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
    public class ProductGroupService : GenericService<ProductGroupBL, ProductGroup>, IProductGroupService
    {
        private IMapper _mapper;
        public ProductGroupService(IGenericRepository<ProductGroup> repository, IMapper mapper) : base(repository)
        {
            _mapper = mapper;
        }
        public override ProductGroupBL Map(ProductGroup entity)
        {
            return _mapper.Map<ProductGroupBL>(entity);
        }

        public override ProductGroup Map(ProductGroupBL blmodel)
        {
            return _mapper.Map<ProductGroup>(blmodel);
        }

        public override IEnumerable<ProductGroupBL> Map(IList<ProductGroup> entities)
        {
            return _mapper.Map<IEnumerable<ProductGroupBL>>(entities);
        }

        public override IEnumerable<ProductGroup> Map(IList<ProductGroupBL> models)
        {
            return _mapper.Map<IEnumerable<ProductGroup>>(models);
        }
    }
}
