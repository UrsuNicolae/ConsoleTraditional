using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using WebApplication1.Dto;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class ProductController : ControllerBase
    {
        private static readonly List<Product> _products = new();

        [HttpGet("{id}", Name = "GetById")]
        public IActionResult GetById(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            if(product == null)
            {
                return NotFound(id);
            }

            return Ok(product);
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(_products);
        }

        [HttpPost]
        public IActionResult CreateProduct(CreateProductDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(modelState: ModelState);
            }
            var productToCreate = new Product
            {
                Name = dto.Name,
                Price = dto.Price,
                Category = dto.Category,
                Id = _products.Count + 1
            };
            _products.Add(productToCreate);

            return CreatedAtRoute("GetById", value: productToCreate, routeValues: new { productToCreate.Id });
        }

        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, CreateProductDto dto)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound(id);
            }

            product.Name = dto.Name;
            product.Price = dto.Price;
            product.Category = dto.Category;

            return Ok(product);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound(id);
            }

            _products.Remove(product);

            return Ok();
        }
    }
}
