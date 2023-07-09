using CowsOnlineShop.Api.Entities;
using CowsOnlineShop.Models.Dtos;

namespace CowsOnlineShop.Api.Extensions
{
    public static class DtoConversions
    {
        public static IEnumerable<ProductBreedDto> ConvertToDto(this IEnumerable<BreedCategory> productCategories)
        {
            return (from productCategory in productCategories
                    select new ProductBreedDto
                    {
                        Id = productCategory.Id,
                        Name = productCategory.Name,
                    }).ToList();
        }
        public static IEnumerable<ProductDto> ConvertToDto(this IEnumerable<Product> products)
        {
            return (from product in products
                    select BuildObjDto(product)).ToList();
        }

        public static ProductDto ConvertToDto(this Product product)  => BuildObjDto(product);

        public static ProductDto ConvertToDto(this Product product, BreedCategory breedCategory)                                                   
        {
            var itemProd = BuildObjDto(product);
            itemProd.CategoryName = breedCategory.Name;
            return itemProd;
        }

        private static  ProductDto BuildObjDto(Product product)
        => new ProductDto
        {
            Id = product.Id,
            Name = product.Name,
            Description = product.Description,
            BirthDate = product.BirthDate,
            Sex = (SexGender)product.Sex,
            ImageURL = product.ImageURL,
            Price = product.Price,
            StockAvailable = product.StockAvailable,
            Status = (PublishStatus)product.Status,
            BreedCategoryId = product.BreedCategory.Id,
            CategoryName = product.BreedCategory.Name
        };


        public static IEnumerable<CartItemDto> ConvertToDto(this IEnumerable<CartItem> cartItems,
                                                            IEnumerable<Product> products)
        {
            return (from cartItem in cartItems
                    join product in products
                    on cartItem.ProductId equals product.Id
                    select BuildCartProductDto(cartItem, product)).ToList();
        }

        public static CartItemDto ConvertToDto(this CartItem cartItem, Product product)
        => BuildCartProductDto(cartItem, product);


        private static CartItemDto BuildCartProductDto(CartItem cartItem, Product product)
        => new CartItemDto
        {
            Id = cartItem.Id,
            ProductId = cartItem.ProductId,
            ProductName = product.Name,
            ProductDescription = product.Description,
            ProductImageURL = product.ImageURL,
            Price = product.Price,
            CartId = cartItem.CartId,
            Qty = cartItem.Qty,
            TotalPrice = product.Price * cartItem.Qty
        };
    }
}
