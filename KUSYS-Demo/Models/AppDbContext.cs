using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace KUSYS_Demo.Models
{
    public class AppDbContext : IdentityDbContext<User, Role, int>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentCourses> StudentCourses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Student>()
                .HasKey(s => s.Id);
            modelBuilder.Entity<Student>()
                .Property(s => s.FirstName)
                .HasMaxLength(50);
            modelBuilder.Entity<Student>()
                .Property(s => s.LastName)
                .HasMaxLength(50);

            modelBuilder.Entity<Course>()
                .HasKey(c => c.Id);
            modelBuilder.Entity<Course>()
                .Property(c => c.Id)
                .HasMaxLength(50);
            modelBuilder.Entity<Course>()
                .Property(c => c.Name)
                .HasMaxLength(50);

            modelBuilder.Entity<StudentCourses>()
                .HasKey(sc => new { sc.StudentId, sc.CourseId });

            modelBuilder.Entity<StudentCourses>()
                .HasOne(sc => sc.Student)
                .WithMany(s => s.StudentCourses)
                .HasForeignKey(sc => sc.StudentId);

            modelBuilder.Entity<StudentCourses>()
                .HasOne(sc => sc.Course)
                .WithMany(c => c.StudentCourses)
                .HasForeignKey(c => c.CourseId);

            SeedCourses(modelBuilder);
            SeedAdminInfo(modelBuilder);
            SeedRoles(modelBuilder);
            SeedUserRole(modelBuilder);
            SeedStudents(modelBuilder);


            base.OnModelCreating(modelBuilder);
        }

        private static void SeedCourses(ModelBuilder builder)
        {
            builder.Entity<Course>().HasData
            (
                new Course() { Id = 1, Code = "CAL183", Name = "Mathematics I" },
                new Course() { Id = 2, Code = "CHE183", Name = "General Chemistry" },
                new Course() { Id = 3, Code = "CME111", Name = "Programming Languages I" },
                new Course() { Id = 4, Code = "PHY101", Name = "Physics" },
                new Course() { Id = 5, Code = "FOL181", Name = "Foreign Language I" },
                new Course() { Id = 6, Code = "HST181", Name = "Atatürk's Principles and History of Revolutions I" },
                new Course() { Id = 7, Code = "PHY183", Name = "General Physics I" },
                new Course() { Id = 8, Code = "CAL186", Name = "Mathematics II" },
                new Course() { Id = 9, Code = "CAL188", Name = "Linear Algebra" },
                new Course() { Id = 10, Code = "CME112", Name = "Programming Languages II" },
                new Course() { Id = 11, Code = "CME114", Name = "Probability and Statistics" },
                new Course() { Id = 12, Code = "FOL182", Name = "Foreign Language II" },
                new Course() { Id = 13, Code = "HST182", Name = "Atatürk's Principles and History of Revolutions II" },
                new Course() { Id = 14, Code = "PHY186", Name = "General Physics II" },
                new Course() { Id = 15, Code = "TRK182", Name = "Turkish Language II" },
                new Course() { Id = 16, Code = "CAL283", Name = "Differantial Equations" },
                new Course() { Id = 17, Code = "CME221", Name = "Logic Circuits" },
                new Course() { Id = 18, Code = "CME223", Name = "Circuit Analysis" },
                new Course() { Id = 19, Code = "CME225", Name = "Object Oriented Programming" },
                new Course() { Id = 20, Code = "CME227", Name = "Data Structures" }
            );
        }

        private static void SeedStudents(ModelBuilder builder)
        {
            builder.Entity<Student>().HasData
            (
                new Student() { Id = 1, FirstName = "Adem", LastName = "ŞAHİN", BirthDate = DateTime.Now.ToString(), CreatedDate = DateTime.Now }
            );
        }

        private static void SeedAdminInfo(ModelBuilder builder)
        {
            builder.Entity<User>().HasData
            (
                new User()
                {
                    Id = 1,
                    FirstName = "Adem",
                    LastName = "Şahin",
                    UserName = "48724704668",
                    BirthDate = new DateTime(1989, 02, 10, 0, 0, 0),
                    NormalizedUserName = "48724704668",
                    Email = "mail.ademsahin@gmail.com",
                    NormalizedEmail = "",
                    EmailConfirmed = true,
                    PasswordHash = "AQAAAAEAACcQAAAAEO7YzXzNNLehzzQjfIhuR+luYXb+ZogV7hARb97WGt4Fo5rUSpjFF1bfovh6lm3F9A==",
                    SecurityStamp = "KPH3JNK3H73Z3PEI7PMYICCAGDXETZKN",
                    ConcurrencyStamp = "4502F6C4-EBD1-458A-8885-5AC4ABB8E88C",
                    PhoneNumber = "5447649382",
                    PhoneNumberConfirmed = true,
                    TwoFactorEnabled = false,
                    LockoutEnd = null,
                    LockoutEnabled = true,
                    AccessFailedCount = 0
                }
            );
        }

        private static void SeedRoles(ModelBuilder builder)
        {
            builder.Entity<Role>().HasData
            (
                new Role() { Id = 1, Name = "Admin", ConcurrencyStamp = "1", NormalizedName = "ADMIN" },
                new Role() { Id = 2, Name = "User", ConcurrencyStamp = "2", NormalizedName = "USER" }
            );
        }

        private static void SeedUserRole(ModelBuilder builder)
        {
            builder.Entity<UserRole>().HasData
            (
                new UserRole() { UserId = 1, RoleId = 1 }
            );
        }
    }
}
