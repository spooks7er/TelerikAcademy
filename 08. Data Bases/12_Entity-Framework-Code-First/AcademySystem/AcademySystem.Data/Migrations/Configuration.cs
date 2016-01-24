namespace AcademySystem.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using AcademySystem.Models;
    using AcademySystem.Data;
    public sealed class Configuration : DbMigrationsConfiguration<AcademyDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
            this.ContextKey = "AcademySystem.Data.AcademyDbContext";
        }

        protected override void Seed(AcademyDbContext db)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
