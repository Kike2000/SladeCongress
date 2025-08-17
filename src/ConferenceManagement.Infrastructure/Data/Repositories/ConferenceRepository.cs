using ConferenceManagement.Domain.Entities;
using ConferenceManagement.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceManagement.Infrastructure.Persistance.Repositories
{
    public class ConferenceRepository : IConferenceRepository
    {
        private readonly AppDbContext _context;

        public ConferenceRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Conference?> GetByIdAsync(int id)
        {
            return await _context.Conferences.FindAsync(id);
        }
    }
}
