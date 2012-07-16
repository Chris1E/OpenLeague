namespace OpenLeague.Infrastructure.Persistence
{
    using System;
    using System.Linq;

    public interface IRepository<T>
    {
        void Add(T entity);

        IQueryable<T> GetAll();

        T GetSingle(Guid id);

        void Update(T entity);
    }
}
