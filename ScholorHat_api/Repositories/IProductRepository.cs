using ScholorHat_api.Models;

namespace ScholorHat_api.Repositories
{
    public interface IProductRepository
    {
        Task<(IEnumerable<Product>, int)> GetAllAsync(ProductQueryParameters parameters);
        Task<Product> GetByIdAsync(int id);
        Task<Product> CreateAsync(Product product);
        Task UpdateAsync(Product product);
        Task DeleteAsync(Product product);
    }
}
