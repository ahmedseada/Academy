using Academy.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Core.Interfaces
{
    public interface IAuthorRepository : IAcademyBaseRepository<Author>
    {
        IEnumerable<Course> GetCourses(string TeacherID);
    }
}
