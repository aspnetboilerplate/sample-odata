using Abp.Domain.Repositories;
using Abp.WebApi.OData;
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
