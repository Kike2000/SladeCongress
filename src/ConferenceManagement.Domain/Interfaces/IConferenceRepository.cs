using ConferenceManagement.Domain.Entities;

namespace ConferenceManagement.Domain.Interfaces
{
    public interface IConferenceRepository
    {
        Task<Conference?> GetByPublicIdAsync(Guid id);

        IQueryable<Conference>? GetAllAsync();

        Task CreateAsync(Conference conference);

        Task<bool> SaveChangesAsync();
    }
}
