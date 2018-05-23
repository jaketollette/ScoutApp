using CoreApp.Core.Abstract;

namespace CoreApp.Core.Concrete
{
    public class Icon : Entity, IDeletable
    {
        public string FileName { get; set; }
        public string Url { get; set; }
    }
}