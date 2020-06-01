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
    public class DeliveryService : GenericService<DeliveryBL, Delivery>, IDeliveryService
    {
        private IMapper _mapper;
        public DeliveryService(IGenericRepository<Delivery> repository, IMapper mapper) : base(repository)
        {
            _mapper = mapper;
        }
        public override DeliveryBL Map(Delivery entity)
        {
            return _mapper.Map<DeliveryBL>(entity);
        }

        public override Delivery Map(DeliveryBL blmodel)
        {
            return _mapper.Map<Delivery>(blmodel);
        }

        public override IEnumerable<DeliveryBL> Map(IList<Delivery> entities)
        {
            return _mapper.Map<IEnumerable<DeliveryBL>>(entities);
        }

        public override IEnumerable<Delivery> Map(IList<DeliveryBL> models)
        {
            return _mapper.Map<IEnumerable<Delivery>>(models);
        }
    }
}
