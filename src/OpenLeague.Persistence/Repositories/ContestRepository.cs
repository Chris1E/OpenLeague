namespace OpenLeague.Persistence.Repositories
{
    using System;
    using System.Linq;
    using OpenLeague.Model.Entities;
    using OpenLeague.Model.Repositories;

    public class ContestRepository : IContestRepository
    {
        private readonly OpenLeagueDbContext openLeagueDbContext;
        
        public ContestRepository()
        {
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

        public Contest GetSingle(object[] id)
        {
            throw new NotImplementedException();
        }
    }
}
