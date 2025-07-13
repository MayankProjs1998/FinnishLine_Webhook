using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinnishLine_Webhook.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UniversityController : ControllerBase
    {
        [HttpGet(Name = "UniverityList")]
        public IActionResult Get()
        {
            return null;
        }
    }
}
