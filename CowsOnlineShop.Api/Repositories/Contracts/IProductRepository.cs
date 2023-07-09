using CowsOnlineShop.Api.Entities;
using CowsOnlineShop.Models.Dtos;

namespace CowsOnlineShop.Api.Repositories.Contracts
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetItems();
        Task<IEnumerable<BreedCategory>> GetCategories();
        Task<Product> GetItem(int id);
        Task<BreedCategory> GetCategory(int id);
        Task<IEnumerable<Product>> GetItemsByCategory(int id);
        Task<Product> AddItem(ProductCrudDto itemDto);
        Task<Product> UpdateItem(int id, ProductCrudDto itemDto);
        Task<Product> DeleteItem(int id);

    }
}
