using DevFreelas.Core.Interfaces.Repositories;
using DevFreelas.Infrastructure.Persistence;
using DevFreelas.Infrastructure.Persistence.Repositories;
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

            services.AddScoped<IProjectsRepository, ProjectsRepository>();
            services.AddScoped<ISkillsRepository, SkillsRepository>();
            services.AddScoped<IUsersRepository, UsersRepository>();

            return services;
        }
    }
}
