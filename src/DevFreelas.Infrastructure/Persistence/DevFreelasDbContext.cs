using System.Reflection;
using DevFreelas.Core.Entities;
using Microsoft.EntityFrameworkCore;

#pragma warning disable CS8618

namespace DevFreelas.Infrastructure.Persistence
{
    public class DevFreelasDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<ProjectComment> ProjectComments { get; set; }
        public DbSet<UserSkill> UserSkills { get; set; }

        public DevFreelasDbContext(DbContextOptions<DevFreelasDbContext> options)
            : base(options)
        {
            //
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(
                Assembly.GetExecutingAssembly()
            );
        }
    }
}
