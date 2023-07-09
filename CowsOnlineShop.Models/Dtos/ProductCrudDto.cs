using System.ComponentModel.DataAnnotations;

namespace CowsOnlineShop.Models.Dtos
{
	public class ProductCrudDto
	{
        public int Id { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "Name is too long.")]
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime BirthDate { get; set; }
        public SexGender Sex { get; set; }
        public string? ImageURL { get; set; }
        [Required]
        public decimal Price { get; set; }
        public int StockAvailable { get; set; }
        public int BreedCategoryId { get; set; }
        public bool Status { get; set; }
    }
}
