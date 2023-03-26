using AspNetCoreWebApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreWebApi.Controllers
{
    [Route("api/v1/learning-class")]
    [ApiController]
    public class LearningController : ControllerBase
    {
        private readonly LearningClassService _learningClassService;

        public LearningController(LearningClassService learningClassService)
        {
            _learningClassService = learningClassService;
        }

        [HttpGet]
        public async Task<ActionResult> Get([FromQuery] string? lecturerName, [FromQuery] int page = 1)
        {
            var Learning = await _learningClassService.GetLearning(lecturerName, page);

            return Ok(Learning);
        }
    }
}
