namespace OpenLeague.Persistence.Repositories
{
    using System;
    using System.Linq;
    using OpenLeague.Model.Entities;
    using OpenLeague.Model.Repositories;

    public class ContestRepository : IContestRepository
    {
        public void Add(Contest entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Contest> GetAll()
        {
            throw new NotImplementedException();
        }

        public Contest GetSingle(object[] id)
        {
            throw new NotImplementedException();
        }
    }
}
