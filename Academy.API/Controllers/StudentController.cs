using Academy.Core.Interfaces;
using Academy.Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Academy.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IAcademyUnitOfWork _unitOfWork;
        public StudentController(IAcademyUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_unitOfWork.Student.List());
        }
        [HttpPost("AddRange")]
        public IActionResult AddRange()
        {
            var students = Enumerable.Range(1, 5).Select(i => new Student() { Grade = Random.Shared.NextDouble() * 4, Name = "Student-" + i , Id = Guid.NewGuid().ToString() });
            _unitOfWork.Student.AddRange(students);
            _unitOfWork.Save();
            return Ok(students);
        }
    }
}
