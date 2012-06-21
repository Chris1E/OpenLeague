namespace OpenLeague.Model.Entities
{
    using System;

    public class Trophy
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public int OrderBy { get; set; }
    }
}
