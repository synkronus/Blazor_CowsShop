using System;
using BlazorBootstrap;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using CowsOnlineShop.Models.Dtos;
using CowsOnlineShop.Web.Services.Contracts;

namespace CowsOnlineShop.Web.Pages
{
	public partial class ProductAdminForm: ComponentBase
	{
        [Inject]
        public IProductService ProductService { get; set; }

        public ProductCrudDto ItemLocal = new();
        private DateTime min1 = new DateTime(2018, 1, 1);
        private DateTime max1 = DateTime.Today;
        public Button saveButton;

        [Parameter] public ProductDto Item { get; set; }
        [Parameter] public FormActionTp Option { get; set; }
        [Parameter] public EventCallback<MouseEventArgs> OnClickCallback { get; set; }

        protected override void OnInitialized()
        {
            Console.WriteLine($"Recieved at ProductForm {Option} \n {Item.Name}");
            switch (Option)
            {
                case FormActionTp.Edit:
                    ItemLocal = BuildObject(Item);
                    break;
                default:
                    ItemLocal = BuildObject(null);
                    break;
            }
        }


        public async Task SaveItem()
        {
            Console.WriteLine($"SaveItem \n {ItemLocal.Name}");
            saveButton?.ShowLoading("Saving...");

            try
            {
                if (ItemLocal.Id == 0) //new
                {
                    var returnedItemDto = await ProductService.AddItem(ItemLocal);
                    Console.WriteLine($"ProductForm Save New returnedItemDto {returnedItemDto.Id}");
                }
                else
                {
                    var returnedItemDto =  await ProductService.UpdateItem(ItemLocal);
                    Console.WriteLine($"ProductForm Save Update returnedItemDto {returnedItemDto.Id}");
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                saveButton?.HideLoading();
                ItemLocal = BuildObject(null);

                await Task.Delay(1000);
                await OnClickCallback.InvokeAsync();
            }

        }


        public ProductCrudDto BuildObject(ProductDto? newItem) => new ProductCrudDto()
        {
            Id = newItem?.Id ?? 0,
            Name = newItem?.Name ?? "",
            Description = newItem?.Description ?? "",
            BirthDate = newItem?.BirthDate ?? DateTime.Now.AddMonths(-5),
            Sex = (newItem?.Sex ?? SexGender.Female),
            ImageURL = "img_url",
            Price = newItem?.Price ?? 0,
            StockAvailable = newItem?.StockAvailable ?? 0,
            BreedCategoryId = newItem?.BreedCategoryId ?? 1,
            Status = (int)(newItem?.Status ?? 0) > 0 
        };
    }
}

