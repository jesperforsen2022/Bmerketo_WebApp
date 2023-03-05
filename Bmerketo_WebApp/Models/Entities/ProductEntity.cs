using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bmerketo_WebApp.Models.Entities
{
    public class ProductEntity
    {
        [Key]
        public string SKU { get; set; } = null!;
        public string Name { get; set; } = null!;
        [Column(TypeName = "Money")]
        public decimal Price { get; set; } 
        public int CategoryId { get; set; }
        public int DescriptionId { get; set; }
        public int ImageId { get; set; }
        public ImageEntity Image { get; set; } = null!;
        public ProductCategoryEntity Category { get; set; } = null!;
        public ProductDescriptionEntity Description { get; set; } = null!;
    }
}
