using DevFreelas.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevFreelas.Infrastructure.Persistence.Configuration
{
    public class ProjectCommentConfiguration :
        IEntityTypeConfiguration<ProjectComment>
    {
        public void Configure(EntityTypeBuilder<ProjectComment> builder)
        {
            builder.ToTable("ProjectComment");

            EntityConfiguration<ProjectComment>.ConfigureEntityId(builder);

            builder.Property(x => x.Content)
                .HasColumnType("varchar(100)");

            builder.HasOne(x => x.Project)
                .WithMany(x => x.Comments)
                .HasForeignKey(x => x.ProjectId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.User)
                .WithMany(x => x.Comments)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}