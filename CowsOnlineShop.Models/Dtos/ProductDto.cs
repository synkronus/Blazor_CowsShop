namespace CowsOnlineShop.Models.Dtos
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime BirthDate { get; set; }
        public SexGender Sex { get; set; }
        public string ImageURL { get; set; }
        public decimal Price { get; set; }
        public int StockAvailable { get; set; }
        public int BreedCategoryId { get; set; }
        public string CategoryName { get; set; }
        public PublishStatus Status { get; set; }

    }
}
