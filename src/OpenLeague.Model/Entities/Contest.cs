namespace OpenLeague.Model.Entities
{
    using System;
    using System.Collections.Generic;

    public class Contest
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public int RoundLengthInDays { get; set; }

        public string CreatedBy { get; set; }

        public bool Deleted { get; set; }

        public int PromotionSpots { get; set; }

        public int PlayoffSpots { get; set; }

        public int ReligationSpots { get; set; }

        public int WinPoints { get; set; }

        public int WinByDefaultPoints { get; set; }

        public int PlayingPoints { get; set; }

        public int NumberOfAllowedDefaultWins { get; set; }

        public int BestOutOf { get; set; }

        public DateTime CloseWarningDate { get; set; }

        public DateTime CloseDate { get; set; }

        public virtual ICollection<Match> Matches { get; set; }
    }
}
