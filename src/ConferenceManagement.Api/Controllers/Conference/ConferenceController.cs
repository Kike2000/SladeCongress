using ConferenceManagement.Api.Extensions;
using ConferenceManagement.Domain.DTOs;
using ConferenceManagement.Domain.Interfaces;
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
        public async Task<ActionResult<ConferenceDto>> GetById(
            [FromRoute] Guid id)
        {
            var conference = await _conferenceService.GetConferenceByPublicIdAsync(id);
            if (conference == null)
            {
                return NotFound();
            }

            return Ok(conference.ToConferenceDto());
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ConferenceDto>>> GetAllConferences()
        {
            var conferences = await _conferenceService.GetAllConferencesAsync();
            var response = conferences.ToResponseList();

            return Ok(response);
        }

        [HttpPost]
        public async Task<bool> CreateConference([FromBody] ConferenceDto conferenceDto)
        {
            return await _conferenceService.CreateConferenceAsync(conferenceDto);
        }
    }
}
