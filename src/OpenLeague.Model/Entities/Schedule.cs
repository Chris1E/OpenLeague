namespace OpenLeague.Model.Entities
{
    using System;

    public class Schedule
    {
        public Guid Id { get; set; }

        public int NumberOfPlayers { get; set; }

        public int LeagueRound { get; set; }

        public int HomePlayerId { get; set; }

        public int AwayPlayerId { get; set; }
    }
}
