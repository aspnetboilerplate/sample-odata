using System.Data.Entity.Migrations;
using AbpODataDemo.People;
using EntityFramework.DynamicFilters;

namespace AbpODataDemo.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<AbpODataDemo.EntityFramework.AbpODataDemoDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "AbpODataDemo";
        }

        protected override void Seed(AbpODataDemo.EntityFramework.AbpODataDemoDbContext context)
        {
            context.DisableAllFilters();

            context.Persons.AddOrUpdate(p => p.Name,
                new Person(
                    "Douglas Adams",
                    new Phone(PhoneType.Mobile, "4242424242"),
                    new Phone(PhoneType.Mobile, "2424242424")
                    ),
                new Person(
                    "John Nash",
                    new Phone(PhoneType.Mobile, "9565015478")
                    )
                );

            context.SaveChanges();
        }
    }
}
