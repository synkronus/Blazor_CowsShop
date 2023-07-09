using Blazored.LocalStorage;
using CowsOnlineShop.Models.Dtos;
using CowsOnlineShop.Web.Services.Contracts;

namespace CowsOnlineShop.Web.Services
{
    public class ManageProductsLclStrgSvc : IManageProductsLocalStorageService
    {
        private readonly ILocalStorageService localStorageService;
        private readonly IProductService productService;

        private const string key = "ProductCollection";

        public ManageProductsLclStrgSvc(ILocalStorageService localStorageService,
                                                 IProductService productService)
        {
            this.localStorageService = localStorageService;
            this.productService = productService;
        }

        public async Task<IEnumerable<ProductDto>> GetCollection(bool forceFetch)
        {
            var restulCache = await this.localStorageService.GetItemAsync<IEnumerable<ProductDto>>(key);
            return (forceFetch || !restulCache.Any()) ? await AddCollection() : restulCache;
        }

        public async Task RemoveCollection()
        {
           await this.localStorageService.RemoveItemAsync(key);
        }

        private async Task<IEnumerable<ProductDto>> AddCollection()
        {
            var productCollection = await this.productService.GetItems();

            if (productCollection != null)
            {
                await this.localStorageService.SetItemAsync(key, productCollection);
            }

            return productCollection;

        }

    }
}
