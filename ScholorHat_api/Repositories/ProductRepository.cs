using Microsoft.EntityFrameworkCore;
using ScholorHat_api.Data;
using ScholorHat_api.Models;

namespace ScholorHat_api.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly MyDBContext _context;

        public ProductRepository(MyDBContext context)
        {
            _context = context;
        }

        public async Task<(IEnumerable<Product>, int)> GetAllAsync(ProductQueryParameters parameters)
        {
            var query = _context.Products.Include(p => p.Category).AsQueryable();

            if (parameters.CategoryId.HasValue)
                query = query.Where(p => p.CategoryId == parameters.CategoryId);

            if (!string.IsNullOrEmpty(parameters.Search))
                query = query.Where(p => p.Name.Contains(parameters.Search));

            if (parameters.SortBy == "price")
                query = parameters.SortDir == "desc" ? query.OrderByDescending(p => p.Price) : query.OrderBy(p => p.Price);
            else
                query = parameters.SortDir == "desc" ? query.OrderByDescending(p => p.Name) : query.OrderBy(p => p.Name);

            var totalCount = await query.CountAsync();
            var items = await query
                .Skip((parameters.Page - 1) * parameters.PageSize)
                .Take(parameters.PageSize)
                .ToListAsync();

            return (items, totalCount);
        }

        public async Task<Product> GetByIdAsync(int id) =>
            await _context.Products.Include(p => p.Category).FirstOrDefaultAsync(p => p.Id == id);

        public async Task<Product> CreateAsync(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return product;
        }

        public async Task UpdateAsync(Product product)
        {
            _context.Products.Update(product);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Product product)
        {
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
        }
    }

}
