using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using AbpODataDemo.Authorization.Roles;
using AbpODataDemo.Authorization.Users;
using AbpODataDemo.MultiTenancy;
using AbpODataDemo.People;

namespace AbpODataDemo.EntityFrameworkCore
{
    public class AbpODataDemoDbContext : AbpZeroDbContext<Tenant, Role, User, AbpODataDemoDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public virtual DbSet<Person> Persons { get; set; }

        public virtual DbSet<Phone> Phones { get; set; }
        
        public AbpODataDemoDbContext(DbContextOptions<AbpODataDemoDbContext> options)
            : base(options)
        {
        }
    }
}
