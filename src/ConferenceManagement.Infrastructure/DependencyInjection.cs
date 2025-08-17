using ConferenceManagement.Domain.Interfaces;
using ConferenceManagement.Domain.Services;
using ConferenceManagement.Infrastructure.Persistance;
using ConferenceManagement.Infrastructure.Persistance.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ConferenceManagement.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(
            this IServiceCollection services,
            IConfiguration config
            )
        {
            services.AddDbContext<AppDbContext>(options =>
                 options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

            services.AddScoped<IConferenceRepository, ConferenceRepository>();
            services.AddScoped<IConferenceService, ConferenceService>();


            return services;
        }
    }
}
