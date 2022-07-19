namespace DevFreelas.Core.Entities
{
    public class ProjectComment : Entity
    {
        public string Content { get; private set; }
        public Guid ProjectId { get; private set; }
        public Project? Project { get; private set; }
        public Guid UserId { get; private set; }
        public User? User { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }

        public ProjectComment(string content, Guid projectId, Guid userId)
        {
            Content = content;
            ProjectId = projectId;
            UserId = userId;
            CreatedAt = DateTime.Now;
            UpdatedAt = CreatedAt;
        }

        public ProjectComment(
            Guid id, string content, Guid projectId, 
            Guid userId, DateTime createdAt, DateTime updatedAt, 
            Project? project, User? user
        ) : base(id)
        {
            Content = content;
            ProjectId = projectId;
            UserId = userId;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;

            Project = project;
            User = user;
        }
    }
}