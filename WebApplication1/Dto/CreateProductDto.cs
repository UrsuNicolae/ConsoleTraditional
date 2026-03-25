using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Dto
{
    public class CreateProductDto
    {
        public string Category { get; set; }

        [Required]
        public string? Name { get; set; }
        public decimal Price { get; set; }
    }
}
