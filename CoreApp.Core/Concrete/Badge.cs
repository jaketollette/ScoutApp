using CoreApp.Core.Abstract;

namespace CoreApp.Core.Concrete
{
    public class Badge : Entity, IDeletable
    {
        public string Name { get; set; }
        public string Summary { get; set; }
        public Icon Icon { get; set; }
    }
}