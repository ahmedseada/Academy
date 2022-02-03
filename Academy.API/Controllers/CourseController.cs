using Academy.Core.Interfaces;
using Academy.Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Academy.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly IAcademyUnitOfWork _unitOfWork;
        public CourseController(IAcademyUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_unitOfWork.Course.List());
        }
        [HttpPost("AddRange")]
        public IActionResult AddRange()
        {
            var courses = Enumerable.Range(1, 5).Select(i => new Course() { NoOfStudents = 1 , TeacherID= "403061e9-60e0-4a3e-84c1-a9127461fb97", ID = Guid.NewGuid().ToString() });
            _unitOfWork.Course.AddRange(courses);
            _unitOfWork.Save();
            return Ok(courses);
        }
        [HttpPost("Add/{title}/{teacherID}")]
        public IActionResult Add(string title ,  string teacherID)
        {
            var course = new Course() { ID = Guid.NewGuid().ToString(), Title = title, NoOfStudents = 2, TeacherID = teacherID };
            _unitOfWork.Course.Add(course);
            _unitOfWork.Save();
            return Ok(course);
        }
    }
}
