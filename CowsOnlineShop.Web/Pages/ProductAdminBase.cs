using System;
using BlazorBootstrap;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using CowsOnlineShop.Models.Dtos;
using CowsOnlineShop.Web.Services;
using CowsOnlineShop.Web.Services.Contracts;

namespace CowsOnlineShop.Web.Pages
{

    public enum FormActionTp
    {
        New,
        Edit,
        Delete
    }

    public class ProductAdminBase : ComponentBase
    {

        public ConfirmDialog dialog;

        public Grid<ProductDto> gridTbl;

        [Inject]
        ToastService ToastService { get; set; }

        [Inject]
        public IProductService ProductService { get; set; }

        public IEnumerable<ProductDto> Products { get; set; }

        public HashSet<ProductDto> selectedItem = new();

        public Modal modal = default!;

        public string? message;

       public  bool disableButton = true;

        protected override async Task OnInitializedAsync()
        {
            Products = await ProductService.GetItems();
        }


        public async Task DeleteItemAsync()
        {
            ProductDto itemSelected = selectedItem.First();

            var confirmation = await dialog.ShowAsync(
              title: "Are you sure you want to delete this?",
              message1: $"Item: {itemSelected.Name}",
              message2: "Do you want to proceed?");

            if (confirmation)
            {
               bool rsltOperation = await ProductService.DeleteItem(itemSelected.Id);
                if(rsltOperation)
                {
                    ToastService.Notify(new ToastMessage(ToastType.Success, $"Item deleted successfully."));
                    await gridTbl.RefreshDataAsync();
                    await OnSelectedItemsChanged(null);
                } else
                    ToastService.Notify(new ToastMessage(ToastType.Danger, $"Something went wrong!"));

            }
            else
                ToastService.Notify(new ToastMessage(ToastType.Secondary, $"Delete action canceled."));
        }

        public bool CalcStatusBool(PublishStatus currentStatus) => currentStatus == PublishStatus.Active;

        public string TruncateString(string str) => str.Length > 25 ? str.Substring(0,25) : str;

        public async Task ShowFormComponent(FormActionTp option)
        {
            Dictionary<string, object> prms = new();
            var titlePrm = "New Item";
            switch (option)
            {
                case FormActionTp.Edit:
                    prms.Add("Item", selectedItem.First<ProductDto>());
                    titlePrm = "Edit Item";
                break;
                default:
                    prms.Add("Item", null);
                break;
            }
            prms.Add("Option", option);
            prms.Add("OnclickCallback", EventCallback.Factory.Create<MouseEventArgs>(this, ShowDTMessage));
            await modal.ShowAsync<ProductAdminForms>(title: titlePrm, parameters: prms);
        }

        public async Task ShowDTMessage()
        {
            await gridTbl.RefreshDataAsync();
            await OnSelectedItemsChanged(null);
            ToastService.Notify(new ToastMessage(ToastType.Success, $"Operation success."));
            await modal.HideAsync();
        }


        public async Task<GridDataProviderResult<ProductDto>> ProductDataProvider(GridDataProviderRequest<ProductDto> request)
        {
            Products = await ProductService.GetItems();
            if (Products is null) 
                Products = await ProductService.GetItems();

            return await Task.FromResult(request.ApplyTo(Products));
        }

        public Task OnSelectedItemsChanged(HashSet<ProductDto> item)
        {
            selectedItem = item is not null && item.Any() ? item : new();
            disableButton = selectedItem.Count == 0;
            return Task.CompletedTask;
        }

    }
}

