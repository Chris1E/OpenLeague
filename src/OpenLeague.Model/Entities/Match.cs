namespace OpenLeague.Model.Entities
{
    using System;

    public class Match
    {
        public Guid Id { get; set; }

        public Guid ContestId { get; set; }

        public int LeagueRound { get; set; }

        public Guid HomePlayerId { get; set; }

        public Guid AwayPlayerId { get; set; }

        public char Result { get; set; }

        public int Margin { get; set; }

        public bool WinByDefault { get; set; }

        public bool RoundStartedEmailSent { get; set; }
    }
}
