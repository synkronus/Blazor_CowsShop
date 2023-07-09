using System.Net.NetworkInformation;
using Microsoft.EntityFrameworkCore;
using CowsOnlineShop.Api.Data;
using CowsOnlineShop.Api.Entities;
using CowsOnlineShop.Api.Repositories.Contracts;
using CowsOnlineShop.Models.Dtos;

namespace CowsOnlineShop.Api.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly CowShopDbContext shopOnlineDbContext;

        public ProductRepository(CowShopDbContext shopOnlineDbContext)
        {
            this.shopOnlineDbContext = shopOnlineDbContext;
        }

        public async Task<Product> AddItem(ProductCrudDto itemDto)
        {
            var prod = new Product()
            {
                Name = itemDto.Name,
                Description = itemDto.Description,
                BirthDate = itemDto.BirthDate,
                Sex = (int)itemDto.Sex,
                Status = itemDto.Status ? 1 : 0,
                ImageURL = "/Images/default/mycow.png",
                Price = itemDto.Price,
                StockAvailable = itemDto.StockAvailable,
                BreedCategoryId = itemDto.BreedCategoryId
            };
            var result = await shopOnlineDbContext.Products.AddAsync(prod);
            await shopOnlineDbContext.SaveChangesAsync();
            return result.Entity;
        }


        public async Task<Product> UpdateItem(int id, ProductCrudDto itemDto)
        {
            Product item = await shopOnlineDbContext.Products.FindAsync(id);

            if (item != null)
            {
                item.Name = itemDto.Name;
                item.Description = itemDto.Description;
                item.BreedCategoryId = itemDto.BreedCategoryId;
                item.Sex = (int)itemDto.Sex;
                item.StockAvailable = itemDto.StockAvailable;
                item.BirthDate = itemDto.BirthDate;
                item.Status = itemDto.Status ? 1 : 0;
                await shopOnlineDbContext.SaveChangesAsync();
                return item;
            }

            return null;
        }


        public async Task<Product> DeleteItem(int id)
        {
            var item = await shopOnlineDbContext.Products.FindAsync(id);

            if (item != null)
            {
                shopOnlineDbContext.Products.Remove(item);
                await shopOnlineDbContext.SaveChangesAsync();
            }

            return item;

        }


        public async Task<IEnumerable<BreedCategory>> GetCategories()
        {
            var categories = await shopOnlineDbContext.BreedCategories.ToListAsync();
           
            return categories; 
        
        }

        public async Task<BreedCategory> GetCategory(int id)
        {
            var category = await shopOnlineDbContext.BreedCategories.SingleOrDefaultAsync(c => c.Id == id);
            return category;
        }

        public async Task<Product> GetItem(int id)
        {
            var product = await shopOnlineDbContext.Products
                                .Include(p => p.BreedCategory)
                                .SingleOrDefaultAsync(p => p.Id == id);
            return product;
        }

        public async Task<IEnumerable<Product>> GetItems()
        {
            var products = await shopOnlineDbContext.Products
                                     .Include(p => p.BreedCategory).ToListAsync();

            return products;
        
        }

        public async Task<IEnumerable<Product>> GetItemsByCategory(int id)
        {
            var products = await shopOnlineDbContext.Products
                                     .Include(p => p.BreedCategory)
                                     .Where(p => p.BreedCategoryId == id).ToListAsync();
            return products;
        }

    }
}
