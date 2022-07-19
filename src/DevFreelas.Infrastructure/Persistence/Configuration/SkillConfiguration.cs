using DevFreelas.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevFreelas.Infrastructure.Persistence.Configuration
{
    public class SkillConfiguration : IEntityTypeConfiguration<Skill>
    {
        public void Configure(EntityTypeBuilder<Skill> builder)
        {
            builder.ToTable("Skill");

            EntityConfiguration<Skill>.ConfigureEntityId(builder);

            builder.Property(x => x.Description)
                .HasColumnType("varchar(100)");
        }
    }
}