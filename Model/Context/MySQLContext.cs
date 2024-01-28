using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext() {}
        public MySQLContext(DbContextOptions<MySQLContext> options) : base (options) {}
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 1,
                Name = "Camisa 1",
                Price = (decimal)10.00,
                Description = "Description",
                ImageUrl = "URL não disponível no momento",
                CategoryName = "T-Shirt"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Camisa 3",
                Price = (decimal)10.00,
                Description = "Description",
                ImageUrl = "URL não disponível no momento",
                CategoryName = "T-Shirt"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "Camisa 4",
                Price = (decimal)10.00,
                Description = "Description",
                ImageUrl = "URL não disponível no momento",
                CategoryName = "T-Shirt"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Name = "Camisa 5",
                Price = (decimal)10.00,
                Description = "Description",
                ImageUrl = "URL não disponível no momento",
                CategoryName = "T-Shirt"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 6,
                Name = "Camisa 6",
                Price = (decimal)10.00,
                Description = "Description",
                ImageUrl = "URL não disponível no momento",
                CategoryName = "T-Shirt"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 7,
                Name = "Camisa 7",
                Price = (decimal)10.00,
                Description = "Description",
                ImageUrl = "URL não disponível no momento",
                CategoryName = "T-Shirt"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 8,
                Name = "Camisa 8",
                Price = (decimal)10.00,
                Description = "Description",
                ImageUrl = "URL não disponível no momento",
                CategoryName = "T-Shirt"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 9,
                Name = "Camisa 9",
                Price = (decimal)10.00,
                Description = "Description",
                ImageUrl = "URL não disponível no momento",
                CategoryName = "T-Shirt"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 10,
                Name = "Camisa 10",
                Price = (decimal)10.00,
                Description = "Description",
                ImageUrl = "URL não disponível no momento",
                CategoryName = "T-Shirt"
            });
        }
    }
}
