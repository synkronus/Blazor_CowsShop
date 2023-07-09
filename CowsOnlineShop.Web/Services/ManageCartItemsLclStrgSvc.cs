using Blazored.LocalStorage;
using CowsOnlineShop.Models.Dtos;
using CowsOnlineShop.Web.Services.Contracts;

namespace CowsOnlineShop.Web.Services
{
    public class CartItemComparer : IComparer<CartItemDto>
    {
        public int Compare(CartItemDto x, CartItemDto y) => y.Id.CompareTo(x.Id);
    }

    public class ManageCartItemsLclStrgSvc : IManageCartItemsLocalStorageService
    {
        private readonly ILocalStorageService localStorageService;
        private readonly IShoppingCartService shoppingCartService;

        const string key = "CartItemCollection";

        public ManageCartItemsLclStrgSvc(ILocalStorageService localStorageService,
                                                  IShoppingCartService shoppingCartService)
        {
            this.localStorageService = localStorageService;
            this.shoppingCartService = shoppingCartService;
        }
        

        public async Task<List<CartItemDto>> GetCollection()
        {
            var result = await this.localStorageService.GetItemAsync<List<CartItemDto>>(key) ?? await AddCollection();
            result.Sort(new CartItemComparer());
            return result;
        }

        public async Task RemoveCollection()
        {
           await this.localStorageService.RemoveItemAsync(key);
        }

        public async Task SaveCollection(List<CartItemDto> cartItemDtos)
        {
            await this.localStorageService.SetItemAsync(key,cartItemDtos);
        }

        private async Task<List<CartItemDto>> AddCollection()
        {
            var shoppingCartCollection = await this.shoppingCartService.GetItems(HardCoded.UserId);

            if(shoppingCartCollection != null)
            {
                await this.localStorageService.SetItemAsync(key, shoppingCartCollection);
            }
            
            return shoppingCartCollection;

        }

    }
}
