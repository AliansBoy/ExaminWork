using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseBL.Interfaces;
using WarehouseBL.Models.Provider;
using WarehouseDAL.Entities;
using WarehouseDAL.Interfaces;

namespace WarehouseBL.Services
{
    public class ProductDeliveryService : GenericService<ProductDeliveryBL, ProductDelivery>, IProductDeliveryService
    {
        private IMapper _mapper;
        public ProductDeliveryService(IGenericRepository<ProductDelivery> repository, IMapper mapper) : base(repository)
        {
            _mapper = mapper;
        }
        public override ProductDeliveryBL Map(ProductDelivery entity)
        {
            return _mapper.Map<ProductDeliveryBL>(entity);
        }

        public override ProductDelivery Map(ProductDeliveryBL blmodel)
        {
            return _mapper.Map<ProductDelivery>(blmodel);
        }

        public override IEnumerable<ProductDeliveryBL> Map(IList<ProductDelivery> entities)
        {
            return _mapper.Map<IEnumerable<ProductDeliveryBL>>(entities);
        }

        public override IEnumerable<ProductDelivery> Map(IList<ProductDeliveryBL> models)
        {
            return _mapper.Map<IEnumerable<ProductDelivery>>(models);
        }
    }
}
