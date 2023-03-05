using Bmerketo_WebApp.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Bmerketo_WebApp.Contexts
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<ProductCategoryEntity> ProductCategories { get; set; }
        public DbSet<ProductDescriptionEntity> ProductDescriptions { get; set; }
        public DbSet<ProductReviewEntity> ProductReviews { get; set; }
        public DbSet<NavLinkEntity> NavLinks { get; set; }
        public DbSet<ImageEntity> Images { get; set; }
        public DbSet<ShowcaseEntity> Showcases { get; set; }
        public DbSet<ProductCardEntity> ProductCards { get; set; }
    }
}
