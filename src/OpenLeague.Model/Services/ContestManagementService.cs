namespace OpenLeague.Model.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using OpenLeague.Infrastructure.Commands;
    using OpenLeague.Model.Command;
    using OpenLeague.Model.Repositories;
    using OpenLeague.Model.ViewModels;

    public class ContestManagementService : IContestManagementService
    {
        private readonly IContestRepository contestRepository;

        private readonly ICommandDispatcher commandDispatcher;

        public ContestManagementService(IContestRepository contestRepository, ICommandDispatcher commandDispatcher)
        {
            this.contestRepository = contestRepository;
            this.commandDispatcher = commandDispatcher;
        }

        public IEnumerable<ContestViewModel> GetAllContests()
        {
            return (from contest in contestRepository.GetAll()
                    select new ContestViewModel
                        {
                            Deleted = contest.Deleted,
                            EndDate = contest.EndDate,
                            Id = contest.Id,
                            Name = contest.Name,
                            StartDate = contest.StartDate
                        })
                    .ToList();
        }

        public void DeleteById(Guid contestId)
        {
            var deleteContestCommand = new ContestDeleteCommand(contestId);
            commandDispatcher.Dispatch(deleteContestCommand);
        }
    }
}