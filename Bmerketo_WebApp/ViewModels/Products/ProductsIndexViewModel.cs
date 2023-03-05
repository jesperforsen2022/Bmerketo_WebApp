using Bmerketo_WebApp.Models.Partials;
using Bmerketo_WebApp.Models;

namespace Bmerketo_WebApp.ViewModels.Products
{
    public class ProductsIndexViewModel : BaseViewModel
    {
        public ShowcaseModel Showcase { get; set; } = null!;
        public IEnumerable<ProductModel> Products { get; set; } = new List<ProductModel>();
    }
}
