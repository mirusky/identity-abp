using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using template.Configuration;
using template.Web;

namespace template.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class templateDbContextFactory : IDesignTimeDbContextFactory<templateDbContext>
    {
        public templateDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<templateDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            templateDbContextConfigurer.Configure(builder, configuration.GetConnectionString(templateConsts.ConnectionStringName));

            return new templateDbContext(builder.Options);
        }
    }
}
