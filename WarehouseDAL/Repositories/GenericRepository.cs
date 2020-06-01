using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WarehouseDAL.Interfaces;

namespace WarehouseDAL.Repositories
{
    public class GenericRepositiory<TEntity> : IGenericRepository<TEntity>
        where TEntity : class
    {
        public readonly DbContext _dbContext;
        public readonly DbSet<TEntity> _dbSet;

        public GenericRepositiory()
        {
            _dbContext = new WarehouseDbContext();/*context ?? throw new ArgumentNullException(nameof(_dbContext));*/
            _dbSet = _dbContext.Set<TEntity>();
        }

        public void Create(TEntity entity)
        {
            DbEntityEntry entry = _dbContext.Entry(entity);
            if (entry.State != EntityState.Detached)
            {
                entry.State = EntityState.Added;
            }
            else
            {
                _dbSet.Add(entity);
                _dbContext.SaveChanges();
            }
        }

        public void Update(TEntity entity)
        {
            DbEntityEntry entry = _dbContext.Entry(entity);
            if (entry.State == EntityState.Detached)
            {
                _dbSet.Attach(entity);
            }
            entry.State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            DbEntityEntry entry = _dbContext.Entry(entity);
            if (entry.State == EntityState.Deleted)
            {
                _dbSet.Attach(entity);
                _dbSet.Remove(entity);
            }
            entry.State = EntityState.Deleted;
            _dbContext.SaveChanges();
        }

        public void Delete(object id)
        {
            var entity = GetById(id);
            if (entity == null) return;
            Delete(entity);
        }

        public bool Exists(object id)
        {
            return GetById(id) != null;
        }

        public IQueryable<TEntity> GetAll()
        {
            return _dbSet;
        }

        public TEntity GetById(object id)
        {
            return _dbSet.Find(id);
        }

        public TEntity Get(Expression<Func<TEntity, bool>> prop)
        {
            return _dbSet.First(prop);
        }

        public IQueryable<TEntity> AllIncluding(params Expression<Func<TEntity, object>>[] includeProperties)
        {
            IQueryable<TEntity> query = GetAll();
            foreach (var prop in includeProperties)
            {
                query.Include(prop);
            }
            return query;
        }

        public IQueryable<TEntity> Where(params Expression<Func<TEntity, bool>>[] predicates)
        {
            IQueryable<TEntity> query = GetAll();
            foreach (var predicate in predicates)
            {
                query = query.Where(predicate);
            }
            return query;
        }

    }
}
