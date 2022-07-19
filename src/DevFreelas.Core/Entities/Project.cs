using DevFreelas.Core.Enums;

namespace DevFreelas.Core.Entities
{
    public class Project : Entity
    {
        public string Title { get; private set; }
        public string Description { get; private set; }
        public Guid ClientId { get; private set; }
        public User? Client { get; private set; }
        public Guid FreelancerId { get; private set; }
        public User? Freelancer { get; private set; }
        public decimal TotalCost { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }
        public DateTime? StartedAt { get; private set; }
        public DateTime? FinishedAt { get; private set; }
        public ProjectStatus Status { get; private set; }
        public List<ProjectComment> Comments { get; private set; }

        public Project(
            string title, string description, 
            Guid clientId, Guid freelancerId, 
            decimal totalCost
        )
        {
            Title = title;
            Description = description;
            ClientId = clientId;
            FreelancerId = freelancerId;
            TotalCost = totalCost;
            CreatedAt = DateTime.Now;
            UpdatedAt = CreatedAt;
            Status = ProjectStatus.Created;

            Comments = new List<ProjectComment>();
        }

        public Project(
            Guid id, string title, string description, 
            Guid clientId, Guid freelancerId, decimal totalCost,
            int status, DateTime createdAt, DateTime updatedAt,
            DateTime? startedAt = null, DateTime? finishedAt = null
        ) : base(id)
        {
            Title = title;
            Description = description;
            ClientId = clientId;
            FreelancerId = freelancerId;
            TotalCost = totalCost;
            Status = (ProjectStatus)status;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            StartedAt = startedAt;
            FinishedAt = finishedAt;

            Comments = new List<ProjectComment>();
        }

        public void Start()
        {
            StartedAt = DateTime.Now;
            Status = ProjectStatus.InProgress;
        }

        public void Finish()
        {
            FinishedAt = DateTime.Now;
            Status = ProjectStatus.Finished;
        }

        public void Cancel()
        {
            if (
                Status == ProjectStatus.Created || 
                Status == ProjectStatus.InProgress
            )
            {
                Status = ProjectStatus.Cancelled;
            }
        }

        public void SetPendingPayment()
        {
            Status = ProjectStatus.Pending;
        }

        public void Update(string title, string description, decimal totalCost)
        {
            Title = title;
            Description = description;
            TotalCost = totalCost;
        }
    }
}