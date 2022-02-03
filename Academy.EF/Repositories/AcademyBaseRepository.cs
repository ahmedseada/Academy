using Academy.Core.Interfaces;
using Academy.EF.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Academy.EF.Repositories
{
    public class AcademyBaseRepository<T> : IAcademyBaseRepository<T> where T  :  class 
    {
        private readonly AcademyDbContext _context;
        public AcademyBaseRepository(AcademyDbContext context)
        {
            _context = context;
        }
        public T Add(T entity)
        {
             _context.Set<T>().Add(entity);
            

            return entity;
        }

        public IEnumerable<T> AddRange(IEnumerable<T> entites)
        {
            _context.Set<T>().AddRange(entites);
            return entites;
        }

        public T Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            

            return entity;
        }

        public IEnumerable<T> List( string[] includes = null)
        {
            IQueryable<T> query = _context.Set<T>();
            if (includes != null)
            {
                foreach (var include in includes)
                {
                   query =  query.Include(include);
                }
            }
            return query.ToList();
        }
 

        public IEnumerable<T> Select(Expression<Func<T, bool>> predicate , string[] includes = null)
        {
            IQueryable<T> query= _context.Set<T>();
            if (includes !=null)
            {
                foreach (var include in includes)
                {
                    query.Include(include);
                }
            }
            return query.Where(predicate);
        }

        public T Update(T entity)
        {
            _context.Set<T>().Update(entity);
            
            return entity;
        }
    }
}
