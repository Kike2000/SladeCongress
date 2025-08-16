using Microsoft.AspNetCore.Mvc;

namespace ConferenceManagement.Api.Controllers.Area
{
    [ApiController]
    [Route("api/[controller]")]
    public class AreaController : ControllerBase
    {
        public AreaController()
        {

        }

        [HttpGet]
        public IActionResult GetAreaById(Guid publicId)
        {
            return Ok();
        }
    }
}
