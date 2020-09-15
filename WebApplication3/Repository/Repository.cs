using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Data;

namespace WebApplication3.Repository
{
    public class Repository<T> : IGenericRepository<T> where T : class
    {
        private AppDbContext _dbcontext;
        private DbSet<T> entities;
        public Repository(AppDbContext dbcontext)
        {
            this._dbcontext = dbcontext;
           
            entities = dbcontext.Set<T>();

        }
        public void Delete(int id)
        {
          //  T entity = entities.SingleOrDefault(s => s.id == id);
          //  entities.Remove(entity);
            _dbcontext.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(T entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");

            entities.Add(entity);
            _dbcontext.SaveChanges();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
