using CoreApp.Core.Abstract;
using System;
using System.Collections.Generic;

namespace CoreApp.Core.Concrete
{
    public class Scout : Entity, IDeletable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? Birthday { get; set; }
        public int RankId { get; set; }
        public Rank Rank { get; set; }
        public int DenId { get; set; }
        public Den Den { get; set; }
        public ICollection<ScoutBadge> ScoutBadges { get; } = new List<ScoutBadge>();
        public DateTime? StartDate { get; set; }
        public bool? Active { get; set; }
    }
}
