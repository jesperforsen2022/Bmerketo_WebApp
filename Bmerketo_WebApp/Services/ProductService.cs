using Bmerketo_WebApp.Contexts;
using Bmerketo_WebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace Bmerketo_WebApp.Services
{
    public class ProductService
    {
        private readonly DataContext _context;

        public ProductService(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ProductModel>> GetProducts()
        {
            var _products = await _context.Products
                .Include(x => x.Category)
                .Include(x => x.Description)
                .Include(x => x.Image)
                .ToListAsync();

            var products = new List<ProductModel>();
            foreach (var product in _products)
            {
                products.Add(new ProductModel
                {
                    Name = product.Name,
                    ShortDescription = product.Description.Short,
                    LongDescription = product.Description.Long,
                    Category = product.Category.Category,
                    ImageUrl = product.Image.Source,
                    Price = product.Price,
                });
            }

            return products;
        }

    }
}
