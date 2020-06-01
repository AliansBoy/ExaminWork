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
    public class ShipmentService : GenericService<ShipmentBL, Shipment>, IShipmentService
    {
        private IMapper _mapper;
        public ShipmentService(IGenericRepository<Shipment> repository, IMapper mapper) : base(repository)
        {
            _mapper = mapper;
        }
        public override ShipmentBL Map(Shipment entity)
        {
            return _mapper.Map<ShipmentBL>(entity);
        }

        public override Shipment Map(ShipmentBL blmodel)
        {
            return _mapper.Map<Shipment>(blmodel);
        }

        public override IEnumerable<ShipmentBL> Map(IList<Shipment> entities)
        {
            return _mapper.Map<IEnumerable<ShipmentBL>>(entities);
        }

        public override IEnumerable<Shipment> Map(IList<ShipmentBL> models)
        {
            return _mapper.Map<IEnumerable<Shipment>>(models);
        }
    }
}
