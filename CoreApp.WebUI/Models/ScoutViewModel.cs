using CoreApp.Core.Concrete;
using System;
using System.Collections.Generic;

namespace CoreApp.WebUI.Models
{
    public class ScoutViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? Birthday { get; set; }
        public Rank Rank { get; set; }
        public Den Den { get; set; }
        public IEnumerable<Badge> Badges { get; set; }
        public DateTime? StartDate { get; set; }
        public bool? Active { get; set; }
    }
}
