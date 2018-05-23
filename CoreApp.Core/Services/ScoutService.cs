using CoreApp.Core.Abstract;
using CoreApp.Core.Concrete;
using System.Collections.Generic;

namespace CoreApp.Core.Services
{
    public class ScoutService : IScoutService
    {
        private readonly IScoutRepository repository;

        public ScoutService(IScoutRepository repository)
        {
            this.repository = repository;
        }

        public IEnumerable<Scout> GetScouts(bool? detail = false)
        {
            return repository.GetScouts(detail);
        }

        public IEnumerable<Scout> GetScouts(Rank rank)
        {
            return repository.GetScouts(rank);
        }

        public IEnumerable<Scout> GetScouts(Den den)
        {
            return repository.GetScouts(den);
        }

        public IEnumerable<Scout> GetScouts(IEnumerable<Badge> badges)
        {
            return repository.GetScouts(badges);
        }

        public IEnumerable<Scout> GetScouts(string lastName, bool? detail = false)
        {
            return repository.GetScouts(lastName, detail);
        }

        public IEnumerable<Scout> GetScouts(string lastName, string firstName, bool? detail = false)
        {
            return repository.GetScouts(lastName, firstName, detail);
        }

        public Scout GetScout(int id, bool? detail = false)
        {
            return repository.GetScout(id, detail);
        }
    }
}
