using Microsoft.EntityFrameworkCore;
using CowsOnlineShop.Api.Entities;

namespace CowsOnlineShop.Api.Data
{
    public class CowShopDbContext:DbContext
    {
        public CowShopDbContext(DbContextOptions<CowShopDbContext> options):base(options) { }

        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<BreedCategory> BreedCategories { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            options.UseSqlite($"Data Source={Path.Join(path, "localSqlite.db")}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SeedData.Seed(modelBuilder);
        }

    }
}
