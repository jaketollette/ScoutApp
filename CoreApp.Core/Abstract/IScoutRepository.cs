using CoreApp.Core.Concrete;
using System.Collections.Generic;

namespace CoreApp.Core.Abstract
{
    public interface IScoutRepository : IRepository<Scout>
    {
        IEnumerable<Scout> GetScouts(bool? detail = false);
        IEnumerable<Scout> GetScouts(Rank rank);
        IEnumerable<Scout> GetScouts(Den den);
        IEnumerable<Scout> GetScouts(IEnumerable<ScoutBadge> badges);
        IEnumerable<Scout> GetScouts(string lastName, bool? detail = false);
        IEnumerable<Scout> GetScouts(string lastName, string firstName, bool? detail = false);
        Scout GetScout(int id, bool? detail = false);

    }
}
