using DevFreelas.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevFreelas.Infrastructure.Persistence.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");

            EntityConfiguration<User>.ConfigureEntityId(builder);

            builder.Property(x => x.FullName)
                .HasColumnType("varchar(200)");

            builder.Property(x => x.Email)
                .HasColumnType("varchar(100)");

            builder.HasMany(x => x.Skills)
                .WithOne()
                .HasForeignKey(x => x.SkillId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}