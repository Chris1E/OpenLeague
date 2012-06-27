namespace OpenLeague.Model.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ContextCollectionViewModel
    {
        public ContextCollectionViewModel(IEnumerable<ContestViewModel> contests)
        {
            Contests = contests;
        }

        public List<ContestViewModel> MyCurrentLeagues
        {
            get
            {
                var contests =
                    Contests.Where(
                        cc =>
                        cc.EndDate >= DateTime.UtcNow.Date &&
                        !cc.Deleted)
                        .ToList();
                return contests;
            }
        }

        public List<ContestViewModel> MyDeletedLeagues
        {
            get
            {
                var contests =
                    Contests.Where(
                        cc =>
                        cc.Deleted)
                        .ToList();
                return contests;
            }
        }

        public List<ContestViewModel> MyOldLeagues
        {
            get
            {
                var contests =
                    Contests.Where(
                        cc =>
                        cc.EndDate < DateTime.UtcNow.Date &&
                        !cc.Deleted)
                        .ToList();
                return contests;
            }
        }
        
        private IEnumerable<ContestViewModel> Contests { get; set; }
    }
}
