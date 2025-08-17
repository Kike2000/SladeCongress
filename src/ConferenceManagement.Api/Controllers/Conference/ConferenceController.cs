using ConferenceManagement.Domain.Interfaces;
using ConferenceManagement.Domain.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConferenceManagement.Api.Controllers.Conference
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConferenceController : ControllerBase
    {
        private readonly IConferenceService _conferenceService;
        public ConferenceController(IConferenceService conferenceService)
        {
            _conferenceService = conferenceService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ConferenceManagement.Domain.Entities.Conference>> GetById([FromRoute]int id)
        {
            var conference = await _conferenceService.GetConferenceByIdAsync(id);
            if (conference == null) return NotFound();
            return Ok(conference);
        }
    }
}
