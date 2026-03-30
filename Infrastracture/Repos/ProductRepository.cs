using Application;
using Application.Dto;
using Application.Repos;
using Domain.Models;

namespace Infrastracture.Repos
{
    public class ProductRepository : IProductRepository
    {
        private static readonly List<Product> _products = new();

        public ProductDto CreateProduct(CreateProductDto product)
        {
            var productToSave = new Product
            {
                Category = product.Category,
                Name = product.Name,
                Id = _products.Count + 1,
                Price = product.Price
            };
            _products.Add(productToSave);
            return new ProductDto
            {
                Category = productToSave.Category,
                Name = productToSave.Name,
                Id = productToSave.Id,
                Price = productToSave.Price
            };
        }

        public void DeleteProduct(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                throw new KeyNotFoundException($"Product id: {id} not found.");
            }

            _products.Remove(product);
        }

        public ProductDto GetProduct(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                throw new KeyNotFoundException($"Product id: {id} not found.");
            }
            return new ProductDto
            {
                Category = product.Category,
                Name = product.Name,
                Id = product.Id,
                Price = product.Price
            };
        }

        public PaginatedList<ProductDto> GetProducts(int pageIndex, int pageSize)
        {
            var products =  _products
                .OrderBy(b => b.Id)
                .Select(product => new ProductDto
                {
                    Category = product.Category,
                    Name = product.Name,
                    Id = product.Id,
                    Price = product.Price
                }).Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            var count = _products.Count();
            var totalPages = (int)Math.Ceiling(count / (double)pageSize);

            return new PaginatedList<ProductDto>(products, pageIndex, totalPages);
        }

        public void UpdateProduct(ProductDto product)
        {
            var productToUpdate = _products.FirstOrDefault(p => p.Id == product.Id);
            if (productToUpdate == null)
            {
                throw new KeyNotFoundException($"Product id: {product.Id} not found.");
            }

            productToUpdate.Name = product.Name;
            productToUpdate.Price = product.Price;
            productToUpdate.Category = product.Category;
        }
    }
}
