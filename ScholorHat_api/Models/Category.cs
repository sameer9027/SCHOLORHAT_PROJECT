using System.ComponentModel.DataAnnotations;

namespace ScholorHat_api.Models
{
    public class Category
    {
        [Key]
        public int CatId { get; set; }
        [Required]
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
