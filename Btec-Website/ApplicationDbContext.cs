
using Btec_Website.Models;
using Microsoft.EntityFrameworkCore;
using Btec_Website.Models.Btec_Website.Models;

namespace Btec_Website
{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Btec_Website.Models.Btec_Website.Models.Subject> Subject { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserCourse>()
                .HasKey(uc => new { uc.UserId, uc.CourseId });

            // Other entity configurations
        }
    }
}
