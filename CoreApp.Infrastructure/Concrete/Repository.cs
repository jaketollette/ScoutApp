using CoreApp.Core.Abstract;
using CoreApp.Core.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CoreApp.Infrastructure.Concrete
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        protected readonly ScoutContext context;
        private DbSet<T> Entities { get; set; }

        public Repository(ScoutContext context)
        {
            this.context = context;
            Entities = context.Set<T>();
        }
        public void Delete(int id)
        {
            var entity = Entities.Where(e => e.Id == id).SingleOrDefault();
            entity.Deleted = true;
            context.SaveChanges();
        }

        public T Get(int id)
        {
            return Entities.Where(e => e.Id == id).SingleOrDefault();
        }

        public IEnumerable<T> GetAll()
        {
            return Entities.AsEnumerable();
        }

        public void Insert(T entity)
        {
            Entities.Add(entity);
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            Entities.Update(entity);
            context.SaveChanges();
        }

        public void Remove(int id)
        {
            var entity = Entities.Where(e => e.Id == id).SingleOrDefault();
            Entities.Remove(entity);
            context.SaveChanges();
        }
    }
}
