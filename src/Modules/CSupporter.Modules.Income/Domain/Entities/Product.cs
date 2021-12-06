using System.ComponentModel.DataAnnotations;

namespace CSupporter.Modules.Products.Domain.Entities
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Category { get; set; }
        [Required]
        public double Price { get; set; }
        public string Details { get; set; }
        public string Description { get; set; }
    }
}
