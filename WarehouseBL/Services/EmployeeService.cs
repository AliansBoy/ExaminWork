using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseBL.Interfaces;
using WarehouseBL.Models.Employee;
using WarehouseDAL.Entities;
using WarehouseDAL.Interfaces;

namespace WarehouseBL.Services
{
    public class EmployeeService : GenericService<EmployeeBL, Employee>, IEmployeeService
    {
        private IMapper _mapper;
        public EmployeeService(IGenericRepository<Employee> repository, IMapper mapper) : base(repository)
        {
            _mapper = mapper;
        }
        public override EmployeeBL Map(Employee entity)
        {
            return _mapper.Map<EmployeeBL>(entity);
        }

        public override Employee Map(EmployeeBL blmodel)
        {
            return _mapper.Map<Employee>(blmodel);
        }

        public override IEnumerable<EmployeeBL> Map(IList<Employee> entities)
        {
            return _mapper.Map<IEnumerable<EmployeeBL>>(entities);
        }

        public override IEnumerable<Employee> Map(IList<EmployeeBL> models)
        {
            return _mapper.Map<IEnumerable<Employee>>(models);
        }
    }
}
