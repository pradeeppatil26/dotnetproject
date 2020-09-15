using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Repository
{
  
        public interface IRepository<T> where T : class
        {
            IEnumerable<T> Get();
            void Insert(T entity);
            void Delete(T entity);
            void Update(T entity);
            T GetById(object id);
        }
    }

