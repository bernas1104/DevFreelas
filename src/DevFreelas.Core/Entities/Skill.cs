namespace DevFreelas.Core.Entities
{
    public class Skill : Entity
    {
        public string Description { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }

        public Skill(string description)
        {
            Description = description;
            CreatedAt = DateTime.Now;
            UpdatedAt = CreatedAt;
        }

        public Skill(
            Guid id, string description, 
            DateTime createdAt, DateTime updatedAt
        ) : base(id)
        {
            Description = description;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }
    }
}