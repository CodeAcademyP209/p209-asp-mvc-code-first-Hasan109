namespace Rent.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Rent.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Rent.DAL.RentContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Rent.DAL.RentContext context)
        {
            context.Rents.AddOrUpdate(
                p => p.Mile,
                new Rents
                {
                    Marka = "Mercedes",
                    Model = "C240",
                    Image="Mercedes.jpg",
                    Mile=230000,
                    Desc= "Problemsiz mashindir"
                }
                );
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
