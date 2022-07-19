using DevFreelas.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevFreelas.Infrastructure.Persistence.Configuration
{
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.ToTable("Project");

            EntityConfiguration<Project>.ConfigureEntityId(builder);

            builder.Property(x => x.Title)
                .HasColumnType("varchar(100)");

            builder.Property(x => x.Description)
                .HasColumnType("nvarchar(max)");

            builder.Property(x => x.TotalCost)
                .HasColumnType("decimal(18, 4)");

            builder.Property(x => x.StartedAt)
                .IsRequired(false);

            builder.Property(x => x.FinishedAt)
                .IsRequired(false);

            builder.HasOne(x => x.Freelancer)
                .WithMany(x => x.FreelanceProjects)
                .HasForeignKey(x => x.FreelancerId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Client)
                .WithMany(x => x.OwnedProjects)
                .HasForeignKey(x => x.ClientId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}