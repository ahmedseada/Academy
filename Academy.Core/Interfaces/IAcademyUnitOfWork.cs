using Academy.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Core.Interfaces
{
    public interface IAcademyUnitOfWork : IDisposable
    {
        public IAuthorRepository Author { get; }
        public IAcademyBaseRepository<Course> Course { get; }
        public IAcademyBaseRepository<Student> Student { get; }
        public IAcademyBaseRepository<Book> Book { get; }
        public IAcademyBaseRepository<StudentCourse> StudentCourse { get; }

        int Save();
        
    }
}
