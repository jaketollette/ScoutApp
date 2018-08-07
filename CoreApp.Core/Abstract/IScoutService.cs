using System.Collections.Generic;
using CoreApp.Core.Concrete;

namespace CoreApp.Core.Abstract
{
    public interface IScoutService
    {
        Scout GetScout(int id, bool? detail = false);
        IEnumerable<Scout> GetScouts(bool? detail = false);
        IEnumerable<Scout> GetScouts(Den den);
        IEnumerable<Scout> GetScouts(IEnumerable<Badge> badges);
        IEnumerable<Scout> GetScouts(Rank rank);
        IEnumerable<Scout> GetScouts(string lastName, bool? detail = false);
        IEnumerable<Scout> GetScouts(string lastName, string firstName, bool? detail = false);
        void AddScout(Scout scout);
    }
}