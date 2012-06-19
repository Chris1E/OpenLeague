namespace OpenLeague.Infrastructure.Persistence
{
    using System.Linq;

    public interface IRepository<T>
        where T : class
    {
        void Add(T entity);

        IQueryable<T> GetAll();

        T GetSingle(object[] id);
    }
}
