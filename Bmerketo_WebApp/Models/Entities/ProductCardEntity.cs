namespace Bmerketo_WebApp.Models.Entities
{
    public class ProductCardEntity
    {
        public int Id { get; set; }
        public NavLinkEntity NavLink { get; set; } = null!;
        public ProductEntity Product { get; set; } = null!;
    }
}
