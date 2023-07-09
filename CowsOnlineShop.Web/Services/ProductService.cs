using Newtonsoft.Json;
using CowsOnlineShop.Models.Dtos;
using CowsOnlineShop.Web.Services.Contracts;
using System.Net.Http.Json;
using System.Text;

namespace CowsOnlineShop.Web.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient httpClient;

        public ProductService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<ProductDto> AddItem(ProductCrudDto itemDto)
        {

            try
            {
                var response = await httpClient.PostAsJsonAsync("api/Product", itemDto);

                if (response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                        return default;

                    return await response.Content.ReadFromJsonAsync<ProductDto>();

                }
                else
                {
                    var message = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Http status:{response.StatusCode} Message -{message}");
                }

            }
            catch (Exception)
            {
                throw;
            }

        }

        public async Task<ProductDto> UpdateItem(ProductCrudDto itemDto)
        {
            try
            {
                var jsonObjReq = JsonConvert.SerializeObject(itemDto);
                var content = new StringContent(jsonObjReq, Encoding.UTF8, "application/json-patch+json");

                var response = await httpClient.PatchAsync($"api/Product/{itemDto.Id}", content);

                if (response.IsSuccessStatusCode)
                    return await response.Content.ReadFromJsonAsync<ProductDto>();

                return null;

            }
            catch (Exception)
            {
                //Log exception
                throw;
            }
        }


        public async Task<bool> DeleteItem(int id)
        {
            try
            {
                var response = await httpClient.DeleteAsync($"api/Product/{id}");

                return (response.IsSuccessStatusCode);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<ProductDto> GetItem(int id)
        {
            try
            {
                var response = await httpClient.GetAsync($"api/Product/{id}");

                if (response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                        return default;

                    return await response.Content.ReadFromJsonAsync<ProductDto>();
                }
                else 
                { 
                    var message = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Http status code: {response.StatusCode} message: {message}");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<ProductDto>> GetItems()
        {
            try
            {
                var response = await this.httpClient.GetAsync("api/Product");

                if (response.IsSuccessStatusCode)
                   return (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                             ? Enumerable.Empty<ProductDto>()
                             : await response.Content.ReadFromJsonAsync<IEnumerable<ProductDto>>();
                else
                {
                    var message = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Http status code: {response.StatusCode} message: {message}");
                }
      
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<ProductDto>> GetItemsByCategory(int categoryId)
        {
            try
            {
                var response = await httpClient.GetAsync($"api/Product/{categoryId}/GetItemsByCategory");

                if (response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                        return Enumerable.Empty<ProductDto>();

                    return await response.Content.ReadFromJsonAsync<IEnumerable<ProductDto>>();
                }
                else
                {
                    var message = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Http Status Code - {response.StatusCode} Message - {message}");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<ProductBreedDto>> GetProductCategories()
        {
            try
            {
                var response = await httpClient.GetAsync("api/Product/GetProductCategories");

                if(response.IsSuccessStatusCode)
                {
                    if(response.StatusCode == System.Net.HttpStatusCode.NoContent)
                        return Enumerable.Empty<ProductBreedDto>();

                    return await response.Content.ReadFromJsonAsync<IEnumerable<ProductBreedDto>>();
                }
                else
                {
                    var message = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Http Status Code - {response.StatusCode} Message - {message}");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
