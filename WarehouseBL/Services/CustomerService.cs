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
    public class CustomerService : GenericService<CustomerBL, Customer>, ICustomerService
    {
        private IMapper _mapper;
        public CustomerService(IGenericRepository<Customer> repository, IMapper mapper) : base(repository)
        {
            _mapper = mapper;
        }
        public override CustomerBL Map(Customer entity)
        {
            return _mapper.Map<CustomerBL>(entity);
        }

        public override Customer Map(CustomerBL blmodel)
        {
            return _mapper.Map<Customer>(blmodel);
        }

        public override IEnumerable<CustomerBL> Map(IList<Customer> entities)
        {
            return _mapper.Map<IEnumerable<CustomerBL>>(entities);
        }

        public override IEnumerable<Customer> Map(IList<CustomerBL> models)
        {
            return _mapper.Map<IEnumerable<Customer>>(models);
        }
    }
}
