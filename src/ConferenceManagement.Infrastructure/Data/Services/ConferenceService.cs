using ConferenceManagement.Domain.Entities;
using ConferenceManagement.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceManagement.Domain.Services
{
    public class ConferenceService : IConferenceService
    {
        private readonly IConferenceRepository _conferenceRepository;

        public ConferenceService(IConferenceRepository conferenceRepository)
        {
            _conferenceRepository = conferenceRepository;
        }

        public Task<Conference?> GetConferenceByIdAsync(int id)
        {
            return _conferenceRepository.GetByIdAsync(id);
        }
    }
}
