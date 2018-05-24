using CoreApp.Core.Concrete;
using System;

namespace CoreApp.Tests.Common.Data
{
    public static class PredefinedData
    {
        public static Scout[] Scouts = new[]
        {
            new Scout { Id = 1, FirstName = "Johnny", LastName = "Smith", Active = true, Birthday = new DateTime(2011, 8, 20), Deleted = false, DenId = 1, Rank = Ranks[0] },
            new Scout { Id = 2, FirstName = "Johnny", LastName = "Doe", Active = true, Birthday = new DateTime(2011, 7, 20), Deleted = false, DenId = 1,  Rank = Ranks[1] },
            new Scout { Id = 3, FirstName = "Billy", LastName = "Jones", Active = true, Birthday = new DateTime(2011, 6, 20), Deleted = false, DenId = 2,  Rank = Ranks[1] },
            new Scout { Id = 4, FirstName = "John", LastName = "Gacey", Active = false, Birthday = new DateTime(2010, 8, 14), Deleted = true, DenId = 3,  Rank = Ranks[2] }
        };

        public static Rank[] Ranks = new[]
        {
            new Rank { Id = 1, Name = "Tiger", Order = 1, Deleted = false, Icon = Icons[3] },
            new Rank { Id = 2, Name = "Wolf", Order = 2, Deleted = false, Icon = Icons[4] },
            new Rank { Id = 3, Name = "Bear", Order = 3, Deleted = false, Icon = Icons[5] }
        };

        public static Leader[] Leaders = new[]
        {
            new Leader { Id = 1, FirstName = "Joe", LastName = "Sucker", Active = true, Deleted = false, DenId = 1 },
            new Leader { Id = 2, FirstName = "Jim", LastName = "Shoulders", Active = true, Deleted = false, DenId = 2 },
            new Leader { Id = 3, FirstName = "John", LastName = "Wayne", Active = true, Deleted = false, DenId = 3 }
        };

        public static Badge[] Badges = new[]
        {
            new Badge { Id = 1, Name = "Tiger Bites", Summary = "This is Tiger Bites", Deleted = false, Icon = Icons[0] },
            new Badge { Id = 2, Name = "Games Tigers Play", Summary = "This is Games Tigers Play", Deleted = false, Icon = Icons[1] },
            new Badge { Id = 3, Name = "First Aid", Summary = "This is First Aid", Deleted = false, Icon = Icons[2] }
        };

        public static ScoutBadge[] ScoutBadges = new[]
        {
            new ScoutBadge { Badge = Badges[0], Scout = Scouts[0] },
            new ScoutBadge { Badge = Badges[1], Scout = Scouts[0] },
            new ScoutBadge { Badge = Badges[2], Scout = Scouts[0] },
            new ScoutBadge { Badge = Badges[0], Scout = Scouts[1] },
            new ScoutBadge { Badge = Badges[1], Scout = Scouts[2] }
        };

        public static Icon[] Icons = new[]
        {
            new Icon { Id = 1, FileName = "tigerbites.svg", Url = "img/icons/tigerbites.svg", Deleted = false },
            new Icon { Id = 2, FileName = "gamestigersplay.svg", Url = "img/icons/gamestigersplay.svg", Deleted = false },
            new Icon { Id = 3, FileName = "firstaid.svg", Url = "img/icons/firstaid.svg", Deleted = false },
            new Icon { Id = 4, FileName = "tiger.svg", Url = "img/icons/tiger.svg", Deleted = false },
            new Icon { Id = 5, FileName = "wolf.svg", Url = "img/icons/wolf.svg", Deleted = false },
            new Icon { Id = 6, FileName = "bear.svg", Url = "img/icons/bear.svg", Deleted = false }
        };

        public static Den[] Dens = new[]
        {
            new Den { Id = 1, Name = "Tigers", Deleted = false },
            new Den { Id = 2, Name = "Wolves", Deleted = false },
            new Den { Id = 3, Name = "Bears", Deleted = false }
        };
    }
}
