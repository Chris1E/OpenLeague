namespace OpenLeague.Model.Services
{
    using System;

    public class ContestViewModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}