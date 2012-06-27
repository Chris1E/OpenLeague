namespace OpenLeague.Model.Services
{
    using System.Collections.Generic;

    using OpenLeague.Model.ViewModels;

    public interface IContestManagementService
    {
        IEnumerable<ContestViewModel> GetAllContests();
    }
}