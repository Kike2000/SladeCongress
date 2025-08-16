using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConferenceManagement.Api.Controllers.Conference
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConferenceController : ControllerBase
    {

        [HttpGet]
        public IActionResult GetAllConferences()
        {
            return Ok();
        }
    }
}
