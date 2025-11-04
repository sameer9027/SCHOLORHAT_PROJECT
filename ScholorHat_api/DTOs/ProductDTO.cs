namespace ScholorHat_api.ViewModels
{
    public class ProductDTO
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedDate { get; set; }
        public CategoryDTO Category { get; set; } // includes Id + Name; Because ProductVM is for output.

    }
}
