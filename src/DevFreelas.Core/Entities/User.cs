using DevFreelas.Core.Enums;

namespace DevFreelas.Core.Entities
{
    public class User : Entity
    {
        public string FullName { get; private set; }
        public string Email { get; private set; }
        public DateTime BirthDate { get; private set; }
        public bool Active { get; private set; }
        public Role Role { get; private set; }
        public string Password { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }
        public List<Project> OwnedProjects { get; private set; }
        public List<Project> FreelanceProjects { get; private set; }
        public List<ProjectComment> Comments { get; private set; }
        public List<UserSkill> Skills { get; private set; }

        public User(
            string fullName, string email, DateTime birthDate,
            Role role, string password
        )
        {
            FullName = fullName;
            Email = email;
            BirthDate = birthDate;
            Role = role;
            Password = password;
            CreatedAt = DateTime.Now;
            Active = true;

            OwnedProjects = new List<Project>();
            FreelanceProjects = new List<Project>();
            Comments = new List<ProjectComment>();
            Skills = new List<UserSkill>();
        }

        public User(
            Guid id, string fullName, string email, DateTime birthDate,
            string password, bool active, DateTime createdAt, DateTime updatedAt
        ) : base(id)
        {
            FullName = fullName;
            Email = email;
            BirthDate = birthDate;
            Password = password;
            Active = active;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;

            OwnedProjects = new List<Project>();
            FreelanceProjects = new List<Project>();
            Comments = new List<ProjectComment>();
            Skills = new List<UserSkill>();
        }
    }
}
