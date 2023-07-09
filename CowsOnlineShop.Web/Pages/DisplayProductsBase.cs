using Microsoft.AspNetCore.Components;
using CowsOnlineShop.Models.Dtos;

namespace CowsOnlineShop.Web.Pages
{
    public class DisplayProductsBase:ComponentBase
    {
        [Parameter]
        public IEnumerable<ProductDto> Products { get; set; }
    
    }
}
