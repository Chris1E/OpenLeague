namespace OpenLeague.Model.Services
{
    using System;

    public class ContestViewModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public bool Deleted { get; set; }

        public string StartDateFomatted
        {
            get
            {
                return StartDate.ToString("d MMM yyyy");
            }
        }

        public string EndDateFormatted
        {
            get
            {
                return EndDate.ToString("d MMM yyyy");
            }
        }
    }
}