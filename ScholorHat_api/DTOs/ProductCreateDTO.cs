using System.ComponentModel.DataAnnotations;

namespace ScholorHat_api.DTOs
{
    public class ProductCreateDTO
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }

        public int CategoryId { get; set; }
    }
}
