using ConfigurationExample.DAL;
using ConfigurationExample.Entities;
using ConfigurationExample.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ConfigurationExample.Repositories.Implementations
{
    internal class Repository<T> :IRepository<T>
        where T:BaseEntity, new()
    {
        protected readonly AppDbContext _context;
        protected readonly DbSet<T> _table;
        public Repository(AppDbContext context)
        {
            _context = context;
            _table = context.Set<T>();
        }

        public void Add(T entity)
        {
            _table.Add(entity);
        }

        public List<T> GetAll()
        {
           
            return _table.AsNoTracking().ToList();
        }

        public T? GetById(int id,bool isTracking=false)
        {
            if (isTracking)
            {
                return _table.FirstOrDefault(s => s.Id == id);
            }

            return _table.AsNoTracking().FirstOrDefault(s => s.Id == id);
        }

        public void Update(T entity)
        {
            _table.Update(entity);
        }

        public void Delete(T entity)
        {
            _table.Remove(entity);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }



    }
}
