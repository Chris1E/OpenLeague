namespace OpenLeague.Infrastructure.Persistence
{
    using System.Linq;

    public interface IRepository<T>
    {
        void Add(T entity);

        IQueryable<T> GetAll();

        T GetSingle(object[] id);
    }
}
