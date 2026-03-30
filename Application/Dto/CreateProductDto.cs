using System.ComponentModel.DataAnnotations;

namespace Application.Dto
{
    public class CreateProductDto
    {
        public string Category { get; set; }

        [Required]
        public string? Name { get; set; }
        public decimal Price { get; set; }
    }
}
