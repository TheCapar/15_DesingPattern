using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace RepositoryDesingPattern.DataAccessLayer.Concrete
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<Context>
    {
        //If you write the following codes, migration will be successful
        public Context CreateDbContext(string[] args)
        {
            // Read appsettings.json
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory()) 
                .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<Context>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            optionsBuilder.UseNpgsql(connectionString);

            return new Context(optionsBuilder.Options);
        }
    }
}
