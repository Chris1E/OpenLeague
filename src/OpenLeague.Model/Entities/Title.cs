namespace OpenLeague.Model.Entities
{
    using System;

    public class Title
    {
        public Guid Id { get; set; }

        public Guid PlayerId { get; set; }

        public Guid TrophyId { get; set; }

        public string Description { get; set; }
    }
}
