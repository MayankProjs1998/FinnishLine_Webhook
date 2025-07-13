using BAL.Service;
using DAL.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinnishLine_Webhook.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {

        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            this._courseService = courseService;
        }

        [HttpGet("CourseList")]
        public async Task<IActionResult> GetCourses()
        {
            var courses = await _courseService.GetAllCoursesAsync();
            return Ok(courses);
        }

        [HttpGet("CourseById/{id}")]
        public async Task<IActionResult> GetCourse(int id)
        {
            var course = await _courseService.GetCourseByIdAsync(id);
            if (course == null) return NotFound();
            return Ok(course);
        }

        [HttpPost("CreateCourse")]
        public async Task<IActionResult> CreateCourse([FromBody] Course course)
        {
            var created = await _courseService.AddCourseAsync(course);
            return CreatedAtAction(nameof(GetCourse), new { id = created.Id }, created);
        }

        [HttpPut("UpdateCourse/{id}")]
        public async Task<IActionResult> UpdateCourse(int id, [FromBody] Course course)
        {
            if (id != course.Id) return BadRequest("ID mismatch");

            var updated = await _courseService.UpdateCourseAsync(course);
            if (updated == null) return NotFound();
            return Ok(updated);
        }

        [HttpDelete("DeleteCourse/{id}")]
        public async Task<IActionResult> DeleteCourse(int id)
        {
            var deleted = await _courseService.DeleteCourseAsync(id);
            if (!deleted) return NotFound();
            return NoContent();
        }
    }
}
