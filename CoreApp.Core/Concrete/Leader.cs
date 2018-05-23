using CoreApp.Core.Abstract;

namespace CoreApp.Core.Concrete
{
    public class Leader : Entity, IDeletable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool? Active { get; set; }
        public Den Den { get; set; }
    }
}