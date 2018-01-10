using Abp.AspNetCore.OData.Controllers;
using Abp.Dependency;
using Abp.Domain.Repositories;
using AbpODataDemo.People;

namespace AbpODataDemo.Controllers
{
    public class PersonsController : AbpODataEntityController<Person>, ITransientDependency
    {
        public PersonsController(IRepository<Person> repository)
            : base(repository)
        {
        }
    }
}
