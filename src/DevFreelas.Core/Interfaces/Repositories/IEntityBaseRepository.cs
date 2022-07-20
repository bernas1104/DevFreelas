namespace DevFreelas.Core.Interfaces.Repositories
{
    public interface IEntityBaseRepository<in TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        void Update(TEntity obj);
    }
}