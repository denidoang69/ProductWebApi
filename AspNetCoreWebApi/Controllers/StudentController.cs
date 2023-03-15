using AspNetCoreWebApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreWebApi.Controllers
{
    [Route("api/v1/student")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly StudentService _studentService;

        public StudentController(StudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public async Task<ActionResult> Get([FromQuery] string? schoolName, [FromQuery] int page = 1)
        {
            var students = await _studentService.GetStudents(schoolName, page);

            return Ok(students);
        }
    }
}
