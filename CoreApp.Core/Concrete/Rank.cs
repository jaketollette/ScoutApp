using CoreApp.Core.Abstract;

namespace CoreApp.Core.Concrete
{
    public class Rank : Entity, IDeletable
    {
        public string Name { get; set; }
        public int Order { get; set; }
        public Icon Icon { get; set; }
    }
}