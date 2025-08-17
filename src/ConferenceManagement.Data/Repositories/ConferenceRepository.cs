using ConferenceManagement.Domain.Conference.Entities;
using ConferenceManagement.Domain.Conference.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceManagement.Data.Repositories
{
    public class ConferenceRepository : IConferenceRepository
    {
        public Task<Conference> GetByIdAsync(Guid publicId)
        {
            throw new NotImplementedException();
        }
    }
}
