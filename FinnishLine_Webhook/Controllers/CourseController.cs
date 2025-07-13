using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinnishLine_Webhook.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        [HttpGet(Name = "CourseList")]
        public IActionResult Get()
        {
            return null;
        }
    }
}
