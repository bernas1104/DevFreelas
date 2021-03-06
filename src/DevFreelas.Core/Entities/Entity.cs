namespace DevFreelas.Core.Entities
{
    public abstract class Entity
    {
        public Guid Id { get; private set; }

        protected Entity(Guid? id = null)
        {
            Id = id ?? Guid.NewGuid();
        }
    }
}
