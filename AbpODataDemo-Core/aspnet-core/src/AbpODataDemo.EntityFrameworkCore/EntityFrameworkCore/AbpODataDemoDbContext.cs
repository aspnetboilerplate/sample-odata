using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using AbpODataDemo.Authorization.Roles;
using AbpODataDemo.Authorization.Users;
using AbpODataDemo.MultiTenancy;

namespace AbpODataDemo.EntityFrameworkCore
{
    public class AbpODataDemoDbContext : AbpZeroDbContext<Tenant, Role, User, AbpODataDemoDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public AbpODataDemoDbContext(DbContextOptions<AbpODataDemoDbContext> options)
            : base(options)
        {
        }
    }
}
