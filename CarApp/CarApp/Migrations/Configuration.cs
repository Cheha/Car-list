namespace CarApp.Migrations
{
    using Data;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using CarApp.Domain;

    internal sealed class Configuration : DbMigrationsConfiguration<AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AppDbContext context)
        {
            context.Brands.AddOrUpdate(_ => 
                _.Name, new Brand { Name = "Mazda" });
            context.Brands.AddOrUpdate(_ => 
                _.Name, new Brand { Name = "Audi" });
            context.Brands.AddOrUpdate(_ => 
                _.Name, new Brand { Name = "Dodge" });

            context.BodyTypes.AddOrUpdate(_ => 
                _.Name, new BodyType { Name = "Sedan"});
            context.BodyTypes.AddOrUpdate(_ => 
                _.Name, new BodyType { Name = "Cabrio" });
        }
    }
}
