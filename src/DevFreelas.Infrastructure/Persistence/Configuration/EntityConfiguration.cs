using DevFreelas.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevFreelas.Infrastructure.Persistence.Configuration
{
    public static class EntityConfiguration<T> where T : Entity
    {
        public static void ConfigureEntityId(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnType("uniqueidentifier");
        }
    }
}