using System.Threading.Tasks;
using System;
using System.Linq;

namespace SharedCore.Repositories
{
    public interface IRepositoryRead<T>
    {
        Task<IQueryable<T>> QueryAll();

        Task<T> Query(Guid key);
        
    }
}