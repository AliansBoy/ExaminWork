using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseBL.Interfaces;
using WarehouseBL.Models;
using WarehouseDAL.Interfaces;
using WarehouseDAL.Repositories;

namespace WarehouseBL.Services
{
    public abstract class GenericService<BLModel, DALModel> : IGenericService<BLModel>
        where BLModel : class
        where DALModel : class
    {
        private readonly IGenericRepository<DALModel> _repository;

        public GenericService(IGenericRepository<DALModel> repository)
        {
            _repository = repository;
        }

        public bool Exist(object id)
        {
            return _repository.Exists(id);
        }

        public void Create(BLModel item)
        {
            var model = Map(item);
            _repository.Create(model);
        }

        public ServiceResponse Delete(object id)
        {
            var deleteCheck = GetById(id);
            if (deleteCheck == null)
            {
                return new ServiceResponse(false, "Wrong Id");
            }
            _repository.Delete(id);
            return new ServiceResponse(true);
        }

        public IEnumerable<BLModel> GetAll()
        {

            var listEntity = _repository.GetAll().ToList();
            return Map(listEntity);
        }

        public IEnumerable<BLModel> AllIncluding()
        {
            var allIncludingList = _repository.AllIncluding().ToList();
            return Map(allIncludingList);
        }

        public BLModel GetById(object id)
        {
            var model = _repository.GetById(id);
            return Map(model);
        }
        public void Update(BLModel item)
        {
            var model = Map(item);
            _repository.Update(model);
        }

        public abstract BLModel Map(DALModel entity);
        public abstract DALModel Map(BLModel blmodel);

        public abstract IEnumerable<BLModel> Map(IList<DALModel> entities);
        public abstract IEnumerable<DALModel> Map(IList<BLModel> models);
    }
}
