using System.Linq;
using Abp.Domain.Repositories;
using Abp.WebApi.OData.Controllers;
using AbpODataDemo.People;
using Microsoft.AspNet.OData;

namespace AbpODataDemo.Controllers
{
    public class PersonsController : AbpODataEntityController<Person>
    {
        private readonly IRepository<Phone> _phoneRepository;

        public PersonsController(
            IRepository<Person> repository,
            IRepository<Phone> phoneRepository)
            : base(
                repository)
        {
            _phoneRepository = phoneRepository;
        }

        //ex: http://localhost:61842/odata/Persons(1)/Phones
        [EnableQuery]
        public virtual IQueryable<Phone> GetPhones([FromODataUri] int key)
        {
            return _phoneRepository.GetAll().Where(ph => ph.PersonId == key);
            //return Repository.Get(key).Phones.AsQueryable(); //Alternative, without need to phone repository.
        }
    }
}
