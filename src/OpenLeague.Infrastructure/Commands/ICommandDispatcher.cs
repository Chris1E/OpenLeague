namespace OpenLeague.Infrastructure.Commands
{
    public interface ICommandDispatcher
    {
        void Dispatch(ICommand command);
    }
}