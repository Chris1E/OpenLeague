namespace OpenLeague.Model.Services
{
    using System.Collections.Generic;

    public interface IContestManagementService
    {
        IEnumerable<ContestViewModel> GetAllContests();
    }
}