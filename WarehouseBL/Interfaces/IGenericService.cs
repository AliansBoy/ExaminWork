using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseBL.Models;

namespace WarehouseBL.Interfaces
{
    public interface IGenericService<T> where T : class
    {
        void Create(T item);
        void Update(T item);
        IEnumerable<T> GetAll();
        ServiceResponse Delete(object id);
        T GetById(object id);
    }
}

