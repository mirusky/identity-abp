using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace template.EntityFrameworkCore
{
    public static class templateDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<templateDbContext> builder, string connectionString)
        {
            builder.UseNpgsql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<templateDbContext> builder, DbConnection connection)
        {
            builder.UseNpgsql(connection);
        }
    }
}
