using Microsoft.EntityFrameworkCore;
using Domain;

namespace Infrastructure
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        public DbSet<Client> Client
        {
            get; set;
        }

        public DbSet<Product> Product
        {
            get; set;
        }
    }
}
