using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Douana.Configuration;
using Douana.Web;

namespace Douana.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class DouanaDbContextFactory : IDesignTimeDbContextFactory<DouanaDbContext>
    {
        public DouanaDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<DouanaDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DouanaDbContextConfigurer.Configure(builder, configuration.GetConnectionString(DouanaConsts.ConnectionStringName));

            return new DouanaDbContext(builder.Options);
        }
    }
}
