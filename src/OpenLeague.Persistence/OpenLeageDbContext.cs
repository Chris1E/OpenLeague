namespace OpenLeague.Persistence
{
    using System.Data.Entity;

    using OpenLeague.Model.Entities;

    public class OpenLeageDbContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
    }
}
