using DevFreelas.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevFreelas.Infrastructure.Persistence.Configuration
{
    public class UserSkillConfiguration : IEntityTypeConfiguration<UserSkill>
    {
        public void Configure(EntityTypeBuilder<UserSkill> builder)
        {
            builder.ToTable("UserSkill");

            EntityConfiguration<UserSkill>.ConfigureEntityId(builder);
        }
    }
}