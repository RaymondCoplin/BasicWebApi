namespace BasicWebApi.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BasicWebApi.Models.ContactContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(BasicWebApi.Models.ContactContext context)
        {
            context.Contacts.Add(new Models.Contact()
            {
                FirstName = "Peter",
                LastName = "Gonzales",
                BirthDay = new DateTime(1981, 9, 2)
            });
        }
    }
}
