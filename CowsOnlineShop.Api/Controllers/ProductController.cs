using Microsoft.AspNetCore.Mvc;
using CowsOnlineShop.Api.Extensions;
using CowsOnlineShop.Api.Repositories.Contracts;
using CowsOnlineShop.Models.Dtos;

namespace CowsOnlineShop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository productRepository;

        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetItems()
        {
            try
            {
                var products = await this.productRepository.GetItems();


                if (products == null)
                { 
                   return NotFound();
                }
                else
                {
                    var productDtos = products.ConvertToDto();

                    return Ok(productDtos);
                }

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                "Error retrieving data from the database");
               
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<ProductDto>> GetItem(int id)
        {
            try
            {
                var product = await this.productRepository.GetItem(id);
               
                if (product == null)
                {
                    return BadRequest();
                }
                else
                {
                    
                    var productDto = product.ConvertToDto();

                    return Ok(productDto);
                }

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                "Error retrieving data from the database");

            }
        }

        [HttpGet]
        [Route(nameof(GetProductCategories))]
        public async Task<ActionResult<IEnumerable<ProductBreedDto>>> GetProductCategories()
        {
            try
            {
                var productBreeds = await productRepository.GetCategories();
                
                var productBreedDtos = productBreeds.ConvertToDto();

                return Ok(productBreedDtos);

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                "Error retrieving data from the database");
            }

        }

        [HttpGet]
        [Route("{categoryId}/GetItemsByCategory")]
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetItemsByCategory(int categoryId)
        {
            try
            {
                var products = await productRepository.GetItemsByCategory(categoryId);

                var productDtos = products.ConvertToDto();

                return Ok(productDtos);
            
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                "Error retrieving data from the database");
            }
        }

        [HttpPost]
        public async Task<ActionResult<ProductDto>> PostItem([FromBody] ProductCrudDto itemDto)
        {
            try
            {
                var newProdItem = await productRepository.AddItem(itemDto);
                if (newProdItem == null)
                    return NoContent();

                var productBreed = await productRepository.GetCategory(newProdItem.BreedCategoryId);
                var productDto = newProdItem.ConvertToDto(productBreed);
                return CreatedAtAction(nameof(GetItem), new { id = productDto.Id }, productDto);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<ProductDto>> DeleteItem(int id)
        {
            try
            {
                if (id == 0)
                    return BadRequest();

                var product = await this.productRepository.GetItem(id);
                if (product == null)
                    return NotFound();

                await this.productRepository.DeleteItem(id);

                return NoContent();

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPatch("{id:int}")]
        public async Task<ActionResult<ProductDto>> UpdateItem(int id, ProductCrudDto itemDto)
        {
            try
            {
                var product = await this.productRepository.GetItem(id);
                if (product == null)
                    return NotFound();

                var prodItem = await this.productRepository.UpdateItem(id, itemDto);
                var productBreed = await productRepository.GetCategory(prodItem.BreedCategoryId);
                return Ok(prodItem.ConvertToDto(productBreed));

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }

        }
    }
}
