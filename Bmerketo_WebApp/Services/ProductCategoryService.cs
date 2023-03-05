using Bmerketo_WebApp.Contexts;
using Bmerketo_WebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace Bmerketo_WebApp.Services
{
    public class ProductCategoryService
    {
        private readonly DataContext _context;

        public ProductCategoryService(DataContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<ProductCategoryModel>> GetCategories()
        {
            var _categories = await _context.ProductCategories
                .ToListAsync();

            var categories = new List<ProductCategoryModel>();
            foreach (var category in _categories)
            {
                categories.Add(new ProductCategoryModel
                {
                    Category = category.Category,
                });
            }

            return categories;
        }
    }
}
