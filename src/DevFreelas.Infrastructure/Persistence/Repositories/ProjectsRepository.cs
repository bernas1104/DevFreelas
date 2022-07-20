using DevFreelas.Core.Entities;
using DevFreelas.Core.Interfaces.Repositories;

namespace DevFreelas.Infrastructure.Persistence.Repositories
{
    public class ProjectsRepository : EntityBaseRepository<Project>,
        IProjectsRepository
    {
        //

        public ProjectsRepository(DevFreelasDbContext context) : base(context)
        {
            //
        }
    }
}
