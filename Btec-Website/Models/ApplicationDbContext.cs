using Microsoft.EntityFrameworkCore;

namespace Btec_Website.Models
{

    public class ApplicationDbContext : DbContext
    {
        // Define your DbSet properties for each entity you want to persist

        // Example:
        // public DbSet<User> Users { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Course> Courses { get; set; }

        string ConnectionString =
        "Data Source=RUFUS\\SQLEXPRESS;Initial Catalog=SMS;Integrated Security=True;Trust Server Certificate=True";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configure the database provider and connection string
            // optionsBuilder.UseSqlServer("your_connection_string_here");

            optionsBuilder.UseSqlServer(ConnectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserCourse>()
                .HasKey(uc => new { uc.UserId, uc.CourseId });

            // Other entity configurations
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
         : base(options)
        {
        }
    }
}
