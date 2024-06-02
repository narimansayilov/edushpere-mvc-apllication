using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using EduSphere.Models;

namespace EduSphere.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Composite Key Definition for Teacher_Course
            modelBuilder.Entity<Teacher_Course>().HasKey(tc => new
            {
                tc.TeacherId,
                tc.CourseId
            });

            // Relationships between Teacher_Course, Teacher, and Course
            modelBuilder.Entity<Teacher_Course>()
                .HasOne(tc => tc.Course)
                .WithMany(c => c.Teachers_Courses)
                .HasForeignKey(tc => tc.CourseId);

            modelBuilder.Entity<Teacher_Course>()
                .HasOne(tc => tc.Teacher)
                .WithMany(t => t.Teachers_Courses)
                .HasForeignKey(tc => tc.TeacherId);

            base.OnModelCreating(modelBuilder);
        }

        // DbSet properties for your entities
        public DbSet<Company> Companies { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Teacher_Course> Teachers_Courses { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
    }
}
