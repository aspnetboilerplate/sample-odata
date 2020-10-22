using Abp.AspNetCore.OData.Controllers;
using Abp.Dependency;
using Abp.Domain.Repositories;
using Abp.Web.Models;
using AbpODataDemo.People;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace AbpODataDemo.Controllers
{
    [DontWrapResult]
    public class PersonsController : AbpODataEntityController<Person>, ITransientDependency
    {
        public PersonsController(IRepository<Person> repository)
            : base(repository)
        {
        }

        public override Task<IActionResult> Delete([FromODataUri] int key)
        {
            return base.Delete(key);
        }

        public override IQueryable<Person> Get()
        {
            return base.Get();
        }

        public override SingleResult<Person> Get([FromODataUri] int key)
        {
            return base.Get(key);
        }

        public override Task<IActionResult> Patch([FromODataUri] int key, [FromBody] Delta<Person> entity)
        {
            return base.Patch(key, entity);
        }

        public override Task<IActionResult> Post([FromBody] Person entity)
        {
            return base.Post(entity);
        }

        public override Task<IActionResult> Put([FromODataUri] int key, [FromBody] Person update)
        {
            return base.Put(key, update);
        }
    }
}
