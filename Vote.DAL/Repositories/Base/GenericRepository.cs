using Microsoft.EntityFrameworkCore;
using System;
using Vote.DAL.Repositories.Base.Interfaces;

namespace Vote.DAL.Repositories.Base
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        bool disposed = false;
        protected DbContext _dbContext;

        public GenericRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public TEntity Find(Guid id)
        {
            return _dbContext.Set<TEntity>().Find(id);
        }

        public void Create(TEntity entity)
        {
            _dbContext.Set<TEntity>().Add(entity);
        }

        public int Complete()
        {
            return _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                _dbContext.Dispose();
            }

            disposed = true;
        }
    }
}
