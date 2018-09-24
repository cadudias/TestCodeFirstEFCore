using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Infrastructure
{
    public class ApplicationContextFactory : IDesignTimeDbContextFactory<ApplicationContext>
    {
        public IConfiguration Configuration
        {
            get;
        }

        public ApplicationContextFactory(){ }

        public ApplicationContextFactory(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public ApplicationContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("StoreDatabase"));
 
            return new ApplicationContext(optionsBuilder.Options);
        }
    }
    
}
