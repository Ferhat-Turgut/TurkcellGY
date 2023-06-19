using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CourseApp.Services;

namespace CourseApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        //Public API: REST: Representational (Temsili) State Transfer...
        private readonly ICourseService courseService;

        public CoursesController(ICourseService courseService)
        {
            this.courseService = courseService;
        }

        [HttpGet]
        public IActionResult GetCourses()
        {
            var courses = courseService.GetCourseDisplayResponses();
            return Ok(courses);
        }
    }
}
