namespace OpenLeague.Persistence.Repositories
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using OpenLeague.Model.Entities;
    using OpenLeague.Model.Repositories;

    public class ContestRepository : IContestRepository
    {
        private readonly OpenLeagueDbContext openLeagueDbContext;
        
        public ContestRepository()
        {
            Database.SetInitializer(new OpenLeagueDbInitializer());

            openLeagueDbContext = new OpenLeagueDbContext();
        }

        public void Add(Contest entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Contest> GetAll()
        {
            return openLeagueDbContext.Contests;
        }

        public Contest GetSingle(Guid id)
        {
            return openLeagueDbContext.Contests.Find(id);
        }

        public void Update(Contest contest)
        {
            openLeagueDbContext.Contests.Attach(contest);
        }
    }
}
