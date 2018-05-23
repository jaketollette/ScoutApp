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
        private DbSet<T> entities { get; set; }

        public Repository(ScoutContext context)
        {
            this.context = context;
        }
        public void Delete(int id)
        {
            var entity = entities.Where(e => e.Id == id).SingleOrDefault();
            entity.Deleted = true;
            context.SaveChanges();
        }

        public T Get(int id)
        {
            return entities.Where(e => e.Id == id).SingleOrDefault();
        }

        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }

        public void Insert(T entity)
        {
            entities.Add(entity);
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            entities.Update(entity);
            context.SaveChanges();
        }

        public void Remove(int id)
        {
            var entity = entities.Where(e => e.Id == id).SingleOrDefault();
            entities.Remove(entity);
            context.SaveChanges();
        }
    }
}
