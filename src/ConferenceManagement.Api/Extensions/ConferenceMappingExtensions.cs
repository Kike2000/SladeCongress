using ConferenceManagement.Domain.DTOs;
using ConferenceManagement.Domain.Entities;

namespace ConferenceManagement.Api.Extensions
{
    public static class ConferenceMappingExtensions
    {
        public static ConferenceDto ToConferenceDto(this Conference conference)
        {
            return new ConferenceDto
            {
                Title = conference.Title,
                StartDate = conference.StartDate,
                EndDate = conference.EndDate
            };
        }
        public static IEnumerable<ConferenceDto> ToResponseList(this IEnumerable<Conference> conferences)
        {
            return conferences.Select(c => c.ToConferenceDto());
        }
    }
}
