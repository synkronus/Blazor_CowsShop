 using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using CowsOnlineShop.Web;
using CowsOnlineShop.Web.Services;
using CowsOnlineShop.Web.Services.Contracts;
using BlazorBootstrap;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:5000/") });
builder.Services.AddBlazorBootstrap();

builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IShoppingCartService, ShoppingCartService>();

builder.Services.AddBlazoredLocalStorage();

builder.Services.AddScoped<IManageProductsLocalStorageService, ManageProductsLclStrgSvc>();
builder.Services.AddScoped<IManageCartItemsLocalStorageService, ManageCartItemsLclStrgSvc>();

await builder.Build().RunAsync();
