namespace DevFreelas.Core.Entities
{
    public class UserSkill : Entity
    {
        public Guid UserId { get; private set; }
        public Guid SkillId { get; private set; }
        public Skill? Skill { get; private set; }

        public UserSkill(Guid userId, Guid skillId)
        {
            UserId = userId;
            SkillId = skillId;
        }

        public UserSkill(Guid? id, Guid userId, Guid skillId, Skill? skill)
            : base(id)
        {
            UserId = userId;
            SkillId = skillId;
            Skill = skill;
        }
    }
}
