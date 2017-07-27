namespace PMIS.DAL.Migrations
{
    using PMIS.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PMIS.DAL.DB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PMIS.DAL.DB context)
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

            if (context.Users.Count() <= 0)
            {
                context.Users.Add(
                    new Users
                    {
                        Username = "admin",
                        Password = "admin123",
                        UniqueId = Guid.NewGuid(),
                        EmployeeId = "0000-0965"
                    }
                );
                context.Users.Add(
                    new Users
                    {
                        Username = "heycarlxyz",
                        Password = "jeonha",
                        UniqueId = Guid.NewGuid(),
                        EmployeeId = "0000-0953"
                    }
                );
            }
        }
    }
}
