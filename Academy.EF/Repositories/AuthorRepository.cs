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
    public class AuthorRepository : AcademyBaseRepository<Author>, IAuthorRepository
    {
        private readonly AcademyDbContext _context;
        public AuthorRepository(AcademyDbContext context):base(context)
        {
            _context = context;
        }
        public IEnumerable<Course> GetCourses(string TeacherID)
        {
            var courses = _context.Courses.Where(course => course.TeacherID == TeacherID).AsEnumerable();
            return courses;
        }
    }
}
