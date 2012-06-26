namespace OpenLeague.Persistence
{
    using System.Data.Entity;

    using OpenLeague.Model.Entities;

    public class OpenLeagueDbContext : DbContext
    {
        public OpenLeagueDbContext()
            : base("OpenLeagueDbContext")
        {
        }

        public DbSet<Contest> Contests { get; set; }

        public DbSet<Player> Players { get; set; }
    }
}
