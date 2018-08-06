using CoreApp.Core.Abstract;
using CoreApp.Core.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CoreApp.Infrastructure.Concrete
{
    public class ScoutRepository : Repository<Scout>, IScoutRepository
    {
        public ScoutRepository(ScoutContext context) : base(context)
        {
        }

        public IEnumerable<Scout> GetScouts(bool? details = false)
        {
            if((bool) details)
            {
                return context.Scouts
                    .Include(s => s.ScoutBadges)
                        .ThenInclude(b => b.Icon)
                    .Include(s => s.Den)
                    .Include(s => s.Rank)
                        .ThenInclude(r => r.Icon)
                    .AsEnumerable();
            }
            return context.Scouts.AsEnumerable();
        }

        public IEnumerable<Scout> GetScouts(Rank rank)
        {
            return context.Scouts.Where(s => s.Rank == rank).AsEnumerable();
        }

        public IEnumerable<Scout> GetScouts(Den den)
        {
            return context.Scouts.Where(s => s.Den == den).AsEnumerable();
        }

        public IEnumerable<Scout> GetScouts(IEnumerable<ScoutBadge> badges)
        {
            return context.Scouts.Where(s => s.ScoutBadges.All(b => badges.Contains(b))).AsEnumerable();
        }

        public IEnumerable<Scout> GetScouts(string lastName, bool? detail = false)
        {
            if((bool) detail)
            {
                return context.Scouts
                    .Include(s => s.ScoutBadges)
                        .ThenInclude(b => b.Icon)
                    .Include(s => s.Den)
                    .Include(s => s.Rank)
                        .ThenInclude(r => r.Icon)
                    .Where(s => string.Equals(s.LastName, lastName, StringComparison.OrdinalIgnoreCase))
                    .AsEnumerable();
            }
            return context.Scouts.Where(s => string.Equals(s.LastName, lastName, StringComparison.OrdinalIgnoreCase)).AsEnumerable();
        }

        public IEnumerable<Scout> GetScouts(string lastName, string firstName, bool? detail = false)
        {
            if((bool) detail)
            {
                return context.Scouts
                    .Include(s => s.ScoutBadges)
                        .ThenInclude(b => b.Icon)
                    .Include(s => s.Den)
                    .Include(s => s.Rank)
                        .ThenInclude(r => r.Icon)
                    .Where(s => string.Equals(s.LastName, lastName, StringComparison.OrdinalIgnoreCase) &&
                string.Equals(s.FirstName, firstName, StringComparison.OrdinalIgnoreCase)).AsEnumerable();
            }
            return context.Scouts
                .Where(s => string.Equals(s.LastName, lastName, StringComparison.OrdinalIgnoreCase) && 
                string.Equals(s.FirstName, firstName, StringComparison.OrdinalIgnoreCase)).AsEnumerable();
        }

        public Scout GetScout(int id, bool? detail = false)
        {
            if ((bool)detail)
            {
                return context.Scouts
                    .Include(s => s.ScoutBadges)
                        .ThenInclude(b => b.Icon)
                    .Include(s => s.Den)
                    .Include(s => s.Rank)
                        .ThenInclude(r => r.Icon)
                    .Where(s => s.Id == id)
                    .SingleOrDefault();
            }
            return context.Scouts.Where(s => s.Id == id).SingleOrDefault();
        }

    }
}
