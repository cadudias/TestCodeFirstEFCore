using Microsoft.EntityFrameworkCore;
using TestCodeFirstEFCore.Models;

namespace Infrastructure
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        public DbSet<Client> Client
        {
            get; set;
        }

        public DbSet<Product> Product
        {
            get; set;
        }

        public DbSet<Category> Category
        {
            get; set;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductCategory>()
            .HasKey(pc => new { pc.ProductId, pc.CategoryId });

            modelBuilder.Entity<ProductCategory>()
                .HasOne(pc => pc.Product)
                .WithMany(p => p.ProductCategories)
                .HasForeignKey(pc => pc.ProductId);

            modelBuilder.Entity<ProductCategory>()
                .HasOne(pc => pc.Category)
                .WithMany(c => c.ProductCategories)
                .HasForeignKey(pc => pc.CategoryId);

            SeedData(modelBuilder);
        }

        private static void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().HasData(
                            new Client
                            {
                                Id = 1,
                                Name = "William"
                            }
                        );

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "MackBook pro 128 gb" },
                new Product { Id = 2, Name = "MackBook pro 256 gb" },
                new Product { Id = 3, Name = "MackBook Air" },
                new Product { Id = 4, Name = "PlayStation 100" }
            );

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Video Games" },
                new Category { Id = 2, Name = "Computadores" },
                new Category { Id = 3, Name = "Livros" }
            );

            modelBuilder.Entity<ProductCategory>().HasData(
                new ProductCategory { ProductId = 1, CategoryId = 2 },
                new ProductCategory { ProductId = 2, CategoryId = 2 },
                new ProductCategory { ProductId = 3, CategoryId = 2 },
                new ProductCategory { ProductId = 4, CategoryId = 1 }
            );
        }
    }
}
