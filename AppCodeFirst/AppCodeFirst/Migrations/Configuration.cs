namespace AppCodeFirst.Migrations
{
    using AppCodeFirst.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AppCodeFirst.Model.EFContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AppCodeFirst.Model.EFContext context)
        {

            context.User.AddOrUpdate(             
              new User { UserId=1,FirstName= "Andrew", LastName= "Peters" },
              new User { UserId = 2, FirstName = "Brice", LastName = "Lambson" },
              new User { UserId = 3, FirstName = "Rowan", LastName = "Miller" }              
            );

        }
    }
}
