namespace CowsOnlineShop.Api.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime BirthDate { get; set; }
        public int Sex { get; set; }
        public string? ImageURL { get; set; }
        public decimal Price { get; set; }
        public int StockAvailable { get; set; }
        public int BreedCategoryId { get; set; }
        public int Status { get; set; }

        public BreedCategory BreedCategory { get; set; }

    }
}
