using System;

namespace Core.Interfaces
{
    public interface IUnitOfWork: IDisposable
    {
        IGenericRepository<TEntity> Repository<TE
    }
}