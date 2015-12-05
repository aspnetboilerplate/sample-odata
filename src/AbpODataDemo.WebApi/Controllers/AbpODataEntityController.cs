using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.OData;
using Abp.Domain.Entities;
using Abp.Domain.Repositories;
using Abp.Domain.Uow;

namespace AbpODataDemo.Controllers
{
    public abstract class AbpODataEntityController<TEntity> : AbpODataEntityController<TEntity, int> 
        where TEntity : class, IEntity<int>
    {
        protected AbpODataEntityController(IRepository<TEntity> repository) : base(repository)
        {

        }
    }

    public abstract class AbpODataEntityController<TEntity, TPrimaryKey> : ODataController
    where TPrimaryKey: IEquatable<TPrimaryKey>
    where TEntity : class, IEntity<TPrimaryKey>
    {
        public IUnitOfWorkManager UnitOfWorkManager { get; set; }

        protected IRepository<TEntity, TPrimaryKey> Repository { get; private set; }

        private IUnitOfWorkCompleteHandle _unitOfWorkCompleteHandler;
        private bool _disposed;

        protected AbpODataEntityController(IRepository<TEntity, TPrimaryKey> repository)
        {
            Repository = repository;
        }

        public override Task<HttpResponseMessage> ExecuteAsync(HttpControllerContext controllerContext, CancellationToken cancellationToken)
        {
            _unitOfWorkCompleteHandler = UnitOfWorkManager.Begin();
            return base.ExecuteAsync(controllerContext, cancellationToken);
        }
        
        [EnableQuery]
        public IQueryable<TEntity> Get()
        {
            return Repository.GetAll();
        }

        [EnableQuery]
        public SingleResult<TEntity> Get([FromODataUri] TPrimaryKey key)
        {
            var entity = Repository.GetAll().Where(e => Equals(e.Id, key));
            return SingleResult.Create(entity);
        }

        protected override void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                _unitOfWorkCompleteHandler.Complete();
                _unitOfWorkCompleteHandler.Dispose();
            }

            _disposed = true;

            base.Dispose(disposing);
        }
    }
}
