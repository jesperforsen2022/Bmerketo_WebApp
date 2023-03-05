using Bmerketo_WebApp.Services;
using Bmerketo_WebApp.ViewModels.Home;
using Microsoft.AspNetCore.Mvc;

namespace Bmerketo_WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductService _productService;
        private readonly ShowcaseService _showcaseService;
        private readonly ProductCategoryService _productCategoryService;


        public HomeController(ProductService productService, ShowcaseService showcaseService, ProductCategoryService productCategoryService)
        {
            _productService = productService;
            _showcaseService = showcaseService;
            _productCategoryService = productCategoryService;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new HomeIndexViewModel();
            viewModel.Products = await _productService.GetProducts();
            viewModel.Showcase = await _showcaseService.GetLatestShowcase();
            viewModel.ProductCategories = await _productCategoryService.GetCategories();

            ViewData["Title"] = viewModel.PageTitle;
            return View(viewModel);
        }
    }
}
