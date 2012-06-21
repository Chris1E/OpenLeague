namespace OpenLeague.Persistence.Repositories
{
    using System;
    using System.Linq;
    using OpenLeague.Model.Entities;
    using OpenLeague.Model.Repositories;

    public class ContestRepository : IContestRepository
    {
        private readonly OpenLeageDbContext openLeageDbContext;
        
        public ContestRepository()
        {
            openLeageDbContext = new OpenLeageDbContext();
        }

        public void Add(Contest entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Contest> GetAll()
        {
            return openLeageDbContext.Contests;
        }

        public Contest GetSingle(object[] id)
        {
            throw new NotImplementedException();
        }
    }
}
