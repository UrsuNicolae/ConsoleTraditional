using Application.Dto;
using Application.Repos;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]

    public class ProductController : ControllerBase
    {
        private readonly IProductRepository productRepository;

        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        
        [HttpGet("{id}", Name = "GetById")]
        [ResponseCache(Duration = 60, Location = ResponseCacheLocation.Client)]
        public IActionResult GetById(int id)
        {
            var product = productRepository.GetProduct(id);
            return Ok(product);
        }

        [HttpGet]
        public IActionResult GetProducts(int pageIndex, int pageSize)
        {
            return Ok(productRepository.GetProducts(pageIndex, pageSize));
        }

        [HttpPost]
        public IActionResult CreateProduct(CreateProductDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(modelState: ModelState);
            }

            var product = productRepository.CreateProduct(dto);

            return CreatedAtRoute("GetById", value: product, routeValues: new { product.Id });
        }

        [HttpPut]
        public IActionResult UpdateProduct(ProductDto dto)
        {
            productRepository.UpdateProduct(dto);
            var product = productRepository.GetProduct(dto.Id);
            return Ok(product);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            productRepository.DeleteProduct(id);

            return Ok();
        }
    }
}
