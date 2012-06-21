namespace OpenLeague.Model.Entities
{
    using System;

    public class History
    {
        public Guid Id { get; set; }

        public Guid ContestId { get; set; }

        public DateTime Date { get; set; }

        public string Message { get; set; }
    }
}
