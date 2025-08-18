using ConferenceManagement.Domain.DTOs;
using ConferenceManagement.Domain.Entities;
using ConferenceManagement.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ConferenceManagement.Domain.Services
{
    public class ConferenceService : IConferenceService
    {
        private readonly IConferenceRepository _conferenceRepository;

        public ConferenceService(IConferenceRepository conferenceRepository)
        {
            _conferenceRepository = conferenceRepository;
        }

        public async Task<Conference?> GetConferenceByPublicIdAsync(Guid id)
        {
            return await _conferenceRepository.GetByPublicIdAsync(id);
        }

        public async Task<List<Conference>?> GetAllConferencesAsync()
        {
            var conferences = _conferenceRepository.GetAllAsync();
            var filtered = conferences.Where(c => c.StartDate > DateTimeOffset.Now);

            return await filtered.ToListAsync();
        }

        public async Task<bool> CreateConferenceAsync(ConferenceDto conferenceDto)
        {
            if(conferenceDto.StartDate > conferenceDto.EndDate)
            {
                return false;
            }

            var conference = new Conference
            {
                PublicId = Guid.NewGuid(),
                StartDate = conferenceDto.StartDate,
                EndDate = conferenceDto.EndDate,
                Title = conferenceDto.Title,
            };

            await _conferenceRepository.CreateAsync(conference);
            return await _conferenceRepository.SaveChangesAsync();
        }
    }
}
