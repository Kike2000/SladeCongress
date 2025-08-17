using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConferenceManagement.Domain.Conference.Entities;

namespace ConferenceManagement.Domain.Conference.Interfaces
{
    public interface IConferenceRepository
    {
        Task<ConferenceManagement.Domain.Conference.Entities.Conference> GetByIdAsync(Guid publicId);
    }
}
