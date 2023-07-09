

using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using CowsOnlineShop.Web.Services.Contracts;
using CowsOnlineShop.Models.Dtos;

namespace CowsOnlineShop.Web.Pages
{
    public enum ItemCheckDto
    {
        FivePercent,
        SubTotalFivePercent,
        GranTotalFivePercent,
    }

    public class CheckoutBase:ComponentBase
    {
        [Inject]
        public IJSRuntime Js { get; set; }

        protected IEnumerable<CartItemDto> ShoppingCartItems { get; set; }

        protected int TotalQty { get; set; }

        protected string PaymentDescription { get; set; }

        protected decimal PaymentAmount { get; set; }

        [Inject]
        public IShoppingCartService ShoppingCartService { get; set; }

        [Inject]
        public IManageCartItemsLocalStorageService ManageCartItemsLocalStorageService { get; set; }


        protected string DisplayButtons { get; set; } = "block";

        protected override async Task OnInitializedAsync()
        {
            try
            {
                ShoppingCartItems = await ManageCartItemsLocalStorageService.GetCollection();

                if (ShoppingCartItems != null && ShoppingCartItems.Any())
                {
                    Guid orderGuid = Guid.NewGuid();
                    ApplyQuantityBasedDiscount();
                    ApplyDuplicateAnimalCheck();

                    PaymentAmount = ShoppingCartItems.Sum(p => p.TotalPrice);
                    TotalQty = ShoppingCartItems.Sum(p => p.Qty);
                    PaymentDescription = $"O_{HardCoded.UserId}_{orderGuid}";

                }
                else
                {
                    DisplayButtons = "none";
                }

            }
            catch (Exception)
            {
                throw;
            }
        }

        private void ApplyQuantityBasedDiscount()
        {
            foreach (var item in ShoppingCartItems)
            {
                // Apply 5% discount for animals with a quantity greater than 5
                if (item.Qty > 5)
                {
                    decimal discountAmount = item.TotalPrice * 0.05m;
                    item.TotalPrice -= discountAmount;
                }
            }

            // Apply additional 3% discount for total purchase price if more than 10 animals are bought
            if (TotalQty > 10)
            {
                decimal discountAmount = PaymentAmount * 0.03m;
                PaymentAmount -= discountAmount;
            }
        }

        private void ApplyDuplicateAnimalCheck()
        {
            var duplicateAnimals = ShoppingCartItems
                .GroupBy(i => i.Id)
                .Where(g => g.Count() > 1)
                .Select(g => g.Key);

            if (duplicateAnimals.Any())
            {
                string errorMessage = "Duplicate animals found in the order: ";
                errorMessage += string.Join(", ", duplicateAnimals);
                throw new Exception(errorMessage);
            }
        }


        public decimal CalcGranTotal()
        {
            var granTotal =  TotalQty > 10 ? PaymentAmount * 0.97m: PaymentAmount;
            return TotalQty > 20 ? granTotal : granTotal + 1000;
            
        }

            public decimal GetCalcDtoByItem(CartItemDto itemDto, ItemCheckDto dtoCheck)
        {
            return dtoCheck switch
            {
                ItemCheckDto.FivePercent => itemDto.Price * 0.05m,
                ItemCheckDto.SubTotalFivePercent => (itemDto.Price * 0.95m * itemDto.Qty),
                ItemCheckDto.GranTotalFivePercent => (itemDto.TotalPrice * 0.97m ),
                _ => decimal.MinValue,
            };
        }

    }
}
