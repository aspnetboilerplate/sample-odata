using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace AbpODataDemo.EntityFrameworkCore
{
    public static class AbpODataDemoDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<AbpODataDemoDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<AbpODataDemoDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
