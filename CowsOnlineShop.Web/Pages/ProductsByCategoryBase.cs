using Microsoft.AspNetCore.Components;
using CowsOnlineShop.Models.Dtos;
using CowsOnlineShop.Web.Services.Contracts;

namespace CowsOnlineShop.Web.Pages
{
    public class ProductsByCategoryBase:ComponentBase
    {
        [Parameter]
        public int BreedCategoryId { get; set; }
        [Inject]
        public IProductService ProductService { get; set; }

        [Inject]
        public IManageProductsLocalStorageService ManageProductsLocalStorageService { get; set; }

        public IEnumerable<ProductDto> Products { get; set; }
        public string CategoryName { get; set; }
        public string ErrorMessage { get; set; }

        protected override async Task OnParametersSetAsync()
        {
            try
            {
                Products = await GetProductCollectionByCategoryId(BreedCategoryId);
                
                if(Products != null && Products.Count() > 0)
                {
                    var productDto = Products.FirstOrDefault(p => p.BreedCategoryId == BreedCategoryId);
                    
                    if (productDto != null)
                    {
                        CategoryName = productDto.CategoryName;
                    }
                
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
        }

        private async Task<IEnumerable<ProductDto>> GetProductCollectionByCategoryId(int categoryId)
        {
            var productCollection = await ManageProductsLocalStorageService.GetCollection(false);

            if(productCollection != null)
            {
                return productCollection.Where(p => p.BreedCategoryId == categoryId);
            }
            else
            {
                return await ProductService.GetItemsByCategory(categoryId);
            }

        }

    }
}
