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
            return (from c in contestRepository.GetAll() 
                    select new ContestViewModel()).ToList();
        }
    }
}