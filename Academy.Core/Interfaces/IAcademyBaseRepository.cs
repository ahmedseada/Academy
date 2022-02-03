using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Core.Interfaces
{
    public interface IAcademyBaseRepository<T> where T : class
    {
         IEnumerable<T> Select(Expression<Func<T, bool>> predicate, string[] includes = null);
         T Add( T entity);
         IEnumerable<T> AddRange(IEnumerable<T> entites);

        T Update(T entity);
        
        T Delete(T entity);

        IEnumerable<T> List( string[] includes = null);




    }
}
