using DevFreelas.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DevFreelas.Infrastructure
{
    public static class InfrastructureModule
    {
        public static IServiceCollection AddInfrastructure(
            this IServiceCollection services,
            string connectionString
        )
        {
            services.AddDbContext<DevFreelasDbContext>(opt => {
                opt.UseSqlServer(connectionString);
            });
            
            return services;
        }
    }
}