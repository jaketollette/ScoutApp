using CoreApp.Core.Concrete;
using System;

namespace CoreApp.Tests.Common.Data
{
    public static class PredefinedData
    {
        public static Scout[] Scouts() => new[]
        {
            new Scout { FirstName = "Johnny", LastName = "Smith", Active = true, Birthday = new DateTime(2011, 8, 20), Deleted = false, DenId = 1, RankId = 1 },
            new Scout { FirstName = "Johnny", LastName = "Doe", Active = true, Birthday = new DateTime(2011, 7, 20), Deleted = false, DenId = 1,  RankId = 1 },
            new Scout { FirstName = "Billy", LastName = "Jones", Active = true, Birthday = new DateTime(2011, 6, 20), Deleted = false, DenId = 2, RankId = 1 },
            new Scout { FirstName = "John", LastName = "Gacey", Active = false, Birthday = new DateTime(2010, 8, 14), Deleted = true, DenId = 3, RankId = 2 }
        };

        public static Rank[] Ranks() => new[]
        {
            new Rank { Name = "Tiger", Order = 1, Deleted = false, Icon = Icons()[3] },
            new Rank { Name = "Wolf", Order = 2, Deleted = false, Icon = Icons()[4] },
            new Rank { Name = "Bear", Order = 3, Deleted = false, Icon = Icons()[5] }
        };

        public static Leader[] Leaders() => new[]
        {
            new Leader { FirstName = "Joe", LastName = "Sucker", Active = true, Deleted = false, DenId = 1 },
            new Leader { FirstName = "Jim", LastName = "Shoulders", Active = true, Deleted = false, DenId = 2 },
            new Leader { FirstName = "John", LastName = "Wayne", Active = true, Deleted = false, DenId = 3 }
        };

        public static Badge[] Badges() => new[]
        {
            new Badge { Name = "Tiger Bites", Summary = "This is Tiger Bites", Deleted = false, Icon = Icons()[0] },
            new Badge { Name = "Games Tigers Play", Summary = "This is Games Tigers Play", Deleted = false, Icon = Icons()[1] },
            new Badge { Name = "First Aid", Summary = "This is First Aid", Deleted = false, Icon = Icons()[2] }
        };

        public static ScoutBadge[] ScoutBadges() => new[]
        {
            new ScoutBadge { ScoutId = 1, BadgeId = 1 },
            new ScoutBadge { ScoutId = 2, BadgeId = 1 },
            new ScoutBadge { ScoutId = 3, BadgeId = 1 },
            new ScoutBadge { ScoutId = 4, BadgeId = 1 },
            new ScoutBadge { ScoutId = 1, BadgeId = 2 }
        };

        public static Icon[] Icons() => new[]
        {
            new Icon { FileName = "tigerbites.svg", Url = "img/icons/tigerbites.svg", Deleted = false },
            new Icon { FileName = "gamestigersplay.svg", Url = "img/icons/gamestigersplay.svg", Deleted = false },
            new Icon { FileName = "firstaid.svg", Url = "img/icons/firstaid.svg", Deleted = false },
            new Icon { FileName = "tiger.svg", Url = "img/icons/tiger.svg", Deleted = false },
            new Icon { FileName = "wolf.svg", Url = "img/icons/wolf.svg", Deleted = false },
            new Icon { FileName = "bear.svg", Url = "img/icons/bear.svg", Deleted = false }
        };

        public static Den[] Dens() => new[]
        {
            new Den { Name = "Tigers", Deleted = false },
            new Den { Name = "Wolves", Deleted = false },
            new Den { Name = "Bears", Deleted = false }
        };
    }
}
