

namespace SharedCore.Repositories
{
    public interface IRepositoryWrite<T> : IRepositoryRead<T>
    {
         void Insert(T obj);

         void update(T obj);

         void delete(T obj);
    }
}