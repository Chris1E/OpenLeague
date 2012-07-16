namespace OpenLeague.Infrastructure.Commands
{
    public interface ICommandHandler<T>
    {
        void Execute(T command);
    }
}