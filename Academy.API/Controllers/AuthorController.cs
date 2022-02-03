using Academy.Core.Interfaces;
using Academy.Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Academy.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IAcademyUnitOfWork _unitOfWork;
        public AuthorController(IAcademyUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_unitOfWork.Author.List());
        }
        [HttpPost("AddRange")]
        public IActionResult AddRange()
        {
            var authors = Enumerable.Range(1, 5).Select(i => new Author() { Name ="Author-"+i , Id  = Guid.NewGuid().ToString() });
            _unitOfWork.Author.AddRange(authors);
            _unitOfWork.Save();
            return Ok(authors);
        }
        [HttpGet("AuthorCourses/{TeacherID}")]
        public IActionResult AuthorCourses(string TeacherID)
        {
            return Ok( _unitOfWork.Author.GetCourses(TeacherID));
        }
    }
}
