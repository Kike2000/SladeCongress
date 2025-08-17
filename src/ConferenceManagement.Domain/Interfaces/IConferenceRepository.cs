using ConferenceManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceManagement.Domain.Interfaces
{
    public interface IConferenceRepository
    {
        Task<Conference?> GetByIdAsync(int id);
    }
}
