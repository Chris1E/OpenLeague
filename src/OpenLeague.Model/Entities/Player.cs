namespace OpenLeague.Model.Entities
{
    using System;

    public class Player
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Username { get; set; }

        public string PictureUrl { get; set; }
    }
}
