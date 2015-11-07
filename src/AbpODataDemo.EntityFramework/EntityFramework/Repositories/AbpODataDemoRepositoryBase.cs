using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace AbpODataDemo.EntityFramework.Repositories
{
    public abstract class AbpODataDemoRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<AbpODataDemoDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected AbpODataDemoRepositoryBase(IDbContextProvider<AbpODataDemoDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class AbpODataDemoRepositoryBase<TEntity> : AbpODataDemoRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected AbpODataDemoRepositoryBase(IDbContextProvider<AbpODataDemoDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
