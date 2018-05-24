using CoreApp.Core.Abstract;
using System.Collections;
using System.Collections.Generic;

namespace CoreApp.Core.Concrete
{
    public class Badge : Entity, IDeletable
    {
        public string Name { get; set; }
        public string Summary { get; set; }
        public Icon Icon { get; set; }
        public ICollection<ScoutBadge> ScoutBadges { get; } = new List<ScoutBadge>();
    }
}