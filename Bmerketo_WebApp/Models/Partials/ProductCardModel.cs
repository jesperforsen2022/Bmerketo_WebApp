namespace Bmerketo_WebApp.Models.Partials
{
    public class ProductCardModel
    {
        public string ProductName { get; set; } = null!;
        public string ProductImage { get; set; } = null!;
        public string ProductCategory { get; set; } = null!;
        public string CartLink { get; set; } = null!;
        public string NavLink { get; set; } = null!;
        public string ButtonText { get; set; } = string.Empty;
    }
}
