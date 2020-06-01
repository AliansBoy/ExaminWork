using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseDAL.Interfaces
{
    public interface IGenericRepository<T>
    {
        IQueryable<T> AllIncluding(params Expression<Func<T, object>>[] includeProperties);
        IQueryable<T> Where(params Expression<Func<T, bool>>[] predicates);
        T Get(Expression<Func<T, bool>> prop);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Delete(object id);
        IQueryable<T> GetAll();
        T GetById(object id);
        bool Exists(object id);
    }
}
