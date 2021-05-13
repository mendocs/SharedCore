using System.Threading.Tasks;

namespace SharedCore.Repositories
{
    public interface IRepositoryWrite<T> : IRepositoryRead<T>
    {
         Task<T> Insert(T obj);

         Task<long> Update(T obj);

         Task Delete(T obj);
    }
}