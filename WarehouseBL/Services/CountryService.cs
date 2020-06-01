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
    public class CountryService : GenericService<CountryBL, Country>, ICountryService
    {
        private IMapper _mapper;
        public CountryService(IGenericRepository<Country> repository, IMapper mapper) : base(repository)
        {
            _mapper = mapper;
        }
        public override CountryBL Map(Country entity)
        {
            return _mapper.Map<CountryBL>(entity);
        }

        public override Country Map(CountryBL blmodel)
        {
            return _mapper.Map<Country>(blmodel);
        }

        public override IEnumerable<CountryBL> Map(IList<Country> entities)
        {
            return _mapper.Map<IEnumerable<CountryBL>>(entities);
        }

        public override IEnumerable<Country> Map(IList<CountryBL> models)
        {
            return _mapper.Map<IEnumerable<Country>>(models);
        }
    }
}
