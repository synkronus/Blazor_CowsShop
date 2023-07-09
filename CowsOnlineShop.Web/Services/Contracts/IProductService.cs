using CowsOnlineShop.Models.Dtos;

namespace CowsOnlineShop.Web.Services.Contracts
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetItems();
        Task<ProductDto> GetItem(int id);
        Task<IEnumerable<ProductBreedDto>> GetProductCategories();
        Task<IEnumerable<ProductDto>> GetItemsByCategory(int categoryId);

        Task<ProductDto> AddItem(ProductCrudDto itemDto);
        Task<bool> DeleteItem(int id);
        Task<ProductDto> UpdateItem(ProductCrudDto itemDto);
    }
}
