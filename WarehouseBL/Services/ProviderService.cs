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
    public class ProviderService : GenericService<ProviderBL, Provider>, IProviderService
    {
        private IMapper _mapper;
        public ProviderService(IGenericRepository<Provider> repository, IMapper mapper) : base(repository)
        {
            _mapper = mapper;
        }
        public override ProviderBL Map(Provider entity)
        {
            return _mapper.Map<ProviderBL>(entity);
        }

        public override Provider Map(ProviderBL blmodel)
        {
            return _mapper.Map<Provider>(blmodel);
        }

        public override IEnumerable<ProviderBL> Map(IList<Provider> entities)
        {
            return _mapper.Map<IEnumerable<ProviderBL>>(entities);
        }

        public override IEnumerable<Provider> Map(IList<ProviderBL> models)
        {
            return _mapper.Map<IEnumerable<Provider>>(models);
        }
    }
}
