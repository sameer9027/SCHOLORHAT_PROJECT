using System.ComponentModel.DataAnnotations;

namespace ScholorHat_api.ViewModels
{
    public class CategoryDTO
    {
        public int CatId { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
