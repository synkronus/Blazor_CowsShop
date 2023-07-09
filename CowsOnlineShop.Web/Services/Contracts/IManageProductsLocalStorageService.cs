using CowsOnlineShop.Models.Dtos;

namespace CowsOnlineShop.Web.Services.Contracts
{
    public interface IManageProductsLocalStorageService
    {
        Task<IEnumerable<ProductDto>> GetCollection(bool forceFetch);
        Task RemoveCollection();
    }
}
