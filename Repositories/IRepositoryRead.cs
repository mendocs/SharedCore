using System;
using System.Linq;

namespace SharedCore.Repositories
{
    public interface IRepositoryRead<T>
    {
        IQueryable<T> QueryAll();

        T Query(Guid key);
        
    }
}