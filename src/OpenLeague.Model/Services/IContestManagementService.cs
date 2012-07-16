namespace OpenLeague.Model.Services
{
    using System;
    using System.Collections.Generic;

    using OpenLeague.Model.ViewModels;

    public interface IContestManagementService
    {
        IEnumerable<ContestViewModel> GetAllContests();

        void DeleteById(Guid contestId);
    }
}