using System;
using System.Linq;

namespace SharedCore.Repository
{
    public interface IRepositoryRead<T>
    {
        IQueryable<T> QueryAll();

        T Query(Guid key);
        
    }
}