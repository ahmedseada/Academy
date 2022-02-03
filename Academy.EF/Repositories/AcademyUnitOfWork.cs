using Academy.Core.Interfaces;
using Academy.Core.Models;
using Academy.EF.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.EF.Repositories
{
    public class AcademyUnitOfWork :  IAcademyUnitOfWork
    {
        private readonly AcademyDbContext _context;
        public IAuthorRepository Author { get;private set; }
        public IAcademyBaseRepository<Course> Course  { get;private set; }
        public IAcademyBaseRepository<Student> Student  { get;private set; }
        public IAcademyBaseRepository<Book> Book  { get;private set; }
        public IAcademyBaseRepository<StudentCourse> StudentCourse  { get;private set; }
        public AcademyUnitOfWork(AcademyDbContext context)
        {
            _context = context;
            Author = new AuthorRepository(context);
            Student = new AcademyBaseRepository<Student>(context);
            Course = new AcademyBaseRepository<Course>(context);
            Book = new AcademyBaseRepository<Book>(context);
            StudentCourse = new AcademyBaseRepository<StudentCourse>(context);
        }

        public void Dispose()
        {
            _context.Dispose();
        }
        public int Save()
        {
            return _context.SaveChanges();
        }
    }
}
