using System;

namespace Vote.DAL.Repositories.Base.Interfaces
{
    public interface IGenericRepository<TEntity> : IDisposable where TEntity : class
    {
        TEntity Find(Guid id);
        void Create(TEntity entity);
        int Complete();
    }
}
