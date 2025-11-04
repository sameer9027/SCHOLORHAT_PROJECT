using System.ComponentModel.DataAnnotations;

namespace ScholorHat_api.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
