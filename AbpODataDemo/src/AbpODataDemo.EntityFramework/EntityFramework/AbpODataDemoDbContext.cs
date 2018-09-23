using System.Data.Entity;
using Abp.EntityFramework;
using AbpODataDemo.People;

namespace AbpODataDemo.EntityFramework
{
    public class AbpODataDemoDbContext : AbpDbContext
    {
        public virtual IDbSet<Person> Persons { get; set; }

        public virtual IDbSet<Phone> Phones{ get; set; }

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public AbpODataDemoDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in AbpODataDemoDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of AbpODataDemoDbContext since ABP automatically handles it.
         */
        public AbpODataDemoDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }
    }
}
