using CoreApp.Core.Abstract;
using System.Collections.Generic;

namespace CoreApp.Core.Concrete
{
    public class Den : Entity, IDeletable
    {
        public string Name { get; set; }
        public IEnumerable<Leader> Leader { get; set; }
    }
}
