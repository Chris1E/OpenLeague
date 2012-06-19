namespace OpenLeague.Infrastructure.Persistence
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}
