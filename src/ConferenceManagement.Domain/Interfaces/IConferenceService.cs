using ConferenceManagement.Domain.DTOs;
using ConferenceManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceManagement.Domain.Interfaces
{
    public interface IConferenceService
    {
        Task<Conference?> GetConferenceByPublicIdAsync(Guid publicId);

        Task<List<Conference>?> GetAllConferencesAsync();

        Task<bool> CreateConferenceAsync(ConferenceDto conferenceDto);

    }
}
