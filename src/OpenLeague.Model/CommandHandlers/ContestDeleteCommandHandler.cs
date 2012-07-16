namespace OpenLeague.Model.CommandHandlers
{
    using OpenLeague.Infrastructure.Commands;
    using OpenLeague.Infrastructure.Persistence;
    using OpenLeague.Model.Command;
    using OpenLeague.Model.Repositories;

    public class ContestDeleteCommandHandler : ICommandHandler<ContestDeleteCommand>
    {
        private readonly IContestRepository contestRepository;

        private readonly IUnitOfWork unitOfWork;

        public ContestDeleteCommandHandler(IContestRepository contestRepository, IUnitOfWork unitOfWork)
        {
            this.contestRepository = contestRepository;
            this.unitOfWork = unitOfWork;
        }

        public void Execute(ContestDeleteCommand contestDeleteCommand)
        {
            var contest = contestRepository.GetSingle(contestDeleteCommand.Id);
            contest.Deleted = true;
            contestRepository.Update(contest);
            unitOfWork.Commit();
        }
    }
}