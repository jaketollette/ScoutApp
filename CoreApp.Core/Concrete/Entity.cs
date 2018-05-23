using CoreApp.Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreApp.Core.Concrete
{
    public class Entity : IEntity, IDeletable
    {
        public int Id { get; set; }
        public bool? Deleted { get; set; }
    }
}
