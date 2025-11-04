namespace ScholorHat_api.Models
{
    public class ProductQueryParameters
    {
        public int? CategoryId { get; set; }         // Optional filter by category
        public string? Search { get; set; }          // Optional search by name
        public string SortBy { get; set; } = "name"; // "name" or "price"
        public string SortDir { get; set; } = "asc"; // "asc" or "desc"
        public int Page { get; set; } = 1;           // Page number (1-based)
        public int PageSize { get; set; } = 10;      // Items per page
    }
}
