using Bmerketo_WebApp.Services;
using Bmerketo_WebApp.ViewModels.Home;
using Bmerketo_WebApp.ViewModels.Products;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Bmerketo_WebApp.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ProductService _productService;

        public ProductsController(ProductService productService)
        {
            _productService = productService;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new ProductsIndexViewModel();
            viewModel.Products = await _productService.GetProducts();
            return View();
        }

        [Authorize(Roles = "Admin, Product Manager")]
        public IActionResult Product()
        {
            return View();
        }
    }
}
