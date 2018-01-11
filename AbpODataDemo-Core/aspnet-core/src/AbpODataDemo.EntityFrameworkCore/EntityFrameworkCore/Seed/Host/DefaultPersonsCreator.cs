using AbpODataDemo.People;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace AbpODataDemo.EntityFrameworkCore.Seed.Host
{
    public class DefaultPersonsCreator
    {
        private readonly AbpODataDemoDbContext _context;

        public DefaultPersonsCreator(AbpODataDemoDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            AddPersonIfNotExists(
                new Person(
                    "Douglas Adams",
                    new Phone(PhoneType.Mobile, "4242424242"),
                    new Phone(PhoneType.Mobile, "2424242424")
                    )
                );

            AddPersonIfNotExists(
                new Person(
                    "John Nash",
                    new Phone(PhoneType.Mobile, "9565015478")
                    )
                );
        }

        private void AddPersonIfNotExists(Person person)
        {
            if (_context.Persons.IgnoreQueryFilters().Any(p => p.Name == person.Name))
            {
                return;
            }

            _context.Persons.Add(person);
            _context.SaveChanges();
        }
    }
}
