using DevFreelas.Core.Entities;
using DevFreelas.Core.Interfaces.Repositories;

namespace DevFreelas.Infrastructure.Persistence.Repositories
{
    public class SkillsRepository : EntityBaseRepository<Skill>,
        ISkillsRepository
    {
        //

        public SkillsRepository(DevFreelasDbContext context) : base(context)
        {
            //
        }
    }
}
