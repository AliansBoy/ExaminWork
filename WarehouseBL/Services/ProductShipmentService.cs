using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseBL.Interfaces;
using WarehouseBL.Models.Customer;
using WarehouseDAL.Entities;
using WarehouseDAL.Interfaces;

namespace WarehouseBL.Services
{
    public class ProductShipmentService : GenericService<ProductShipmentBL, ProductShipment>, IProductShipmentService
    {
        private IMapper _mapper;
        public ProductShipmentService(IGenericRepository<ProductShipment> repository, IMapper mapper) : base(repository)
        {
            _mapper = mapper;
        }
        public override ProductShipmentBL Map(ProductShipment entity)
        {
            return _mapper.Map<ProductShipmentBL>(entity);
        }

        public override ProductShipment Map(ProductShipmentBL blmodel)
        {
            return _mapper.Map<ProductShipment>(blmodel);
        }

        public override IEnumerable<ProductShipmentBL> Map(IList<ProductShipment> entities)
        {
            return _mapper.Map<IEnumerable<ProductShipmentBL>>(entities);
        }

        public override IEnumerable<ProductShipment> Map(IList<ProductShipmentBL> models)
        {
            return _mapper.Map<IEnumerable<ProductShipment>>(models);
        }
    }
}
