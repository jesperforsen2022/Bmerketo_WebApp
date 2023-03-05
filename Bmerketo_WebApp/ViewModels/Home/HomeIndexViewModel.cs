using Bmerketo_WebApp.Models.Partials;
using Bmerketo_WebApp.Models;

namespace Bmerketo_WebApp.ViewModels.Home
{
    public class HomeIndexViewModel : BaseViewModel
    {
        public ShowcaseModel Showcase { get; set; } = new ShowcaseModel();
        public IEnumerable<ProductModel> Products { get; set; } = new List<ProductModel>();

        public IEnumerable<ProductCategoryModel> ProductCategories { get; set; } = new List<ProductCategoryModel>();
        public ProductCardModel ProductCards { get; set; } = new ProductCardModel();
    }
}
