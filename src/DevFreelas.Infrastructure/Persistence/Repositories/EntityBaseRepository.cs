using DevFreelas.Core.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DevFreelas.Infrastructure.Persistence.Repositories
{
    public class EntityBaseRepository<TEntity> : IEntityBaseRepository<TEntity>,
        IDisposable where TEntity : class
    {
        protected readonly DevFreelasDbContext _context;
        protected readonly DbSet<TEntity> _dbSet;

        public EntityBaseRepository(DevFreelasDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }

        public void Add(TEntity obj)
        {
            _dbSet.Add(obj);
        }

        public void Update(TEntity obj)
        {
            _dbSet.Update(obj);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }
    }
}
