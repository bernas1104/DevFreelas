using DevFreelas.Core.Entities;
using DevFreelas.Core.Interfaces.Repositories;

namespace DevFreelas.Infrastructure.Persistence.Repositories
{
    public class UsersRepository : EntityBaseRepository<User>, IUsersRepository
    {
        //

        public UsersRepository(DevFreelasDbContext context) : base(context)
        {
            //
        }
    }
}
