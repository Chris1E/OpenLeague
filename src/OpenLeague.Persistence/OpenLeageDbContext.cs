namespace OpenLeague.Persistence
{
    using System.Data.Entity;

    using OpenLeague.Model.Entities;

    public class OpenLeageDbContext : DbContext
    {
        public OpenLeageDbContext()
            : base("OpenLeagueDbContext")
        {
        }

        public DbSet<Contest> Contests { get; set; }
    }
}
