using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using AbpODataDemo.Configuration;
using AbpODataDemo.Web;

namespace AbpODataDemo.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class AbpODataDemoDbContextFactory : IDesignTimeDbContextFactory<AbpODataDemoDbContext>
    {
        public AbpODataDemoDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AbpODataDemoDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            AbpODataDemoDbContextConfigurer.Configure(builder, configuration.GetConnectionString(AbpODataDemoConsts.ConnectionStringName));

            return new AbpODataDemoDbContext(builder.Options);
        }
    }
}
