namespace OpenLeague.Model.Services
{
    using System.Collections.Generic;
    using System.Linq;

    using OpenLeague.Model.Repositories;

    public class ContestManagementService : IContestManagementService
    {
        private readonly IContestRepository contestRepository;

        public ContestManagementService(IContestRepository contestRepository)
        {
            this.contestRepository = contestRepository;
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
    }
}