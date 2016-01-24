namespace AcademySystem.Data
{
    using System.Data.Entity;
    using Migrations;
    using AcademySystem.Models;

    public class AcademyDbContext : DbContext
    {
        public AcademyDbContext()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<AcademyDbContext, Configuration>());
        }

        public IDbSet<Course> Courses { get; set; }

        public IDbSet<Student> Students { get; set; }

        public IDbSet<Homework> Homeworks { get; set; }
    }
}