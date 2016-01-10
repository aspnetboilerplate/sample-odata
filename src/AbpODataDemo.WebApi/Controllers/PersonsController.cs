using Abp.Domain.Repositories;
using Abp.WebApi.OData.Controllers;
using AbpODataDemo.People;

namespace AbpODataDemo.Controllers
{
    public class PersonsController : AbpODataEntityController<Person>
    {
        public PersonsController(IRepository<Person> repository)
            : base(repository)
        {

        }
    }
}
