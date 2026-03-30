using Application.Dto;

namespace Application.Repos
{
    public interface IProductRepository
    {
        public ProductDto GetProduct(int id);
        public ProductDto CreateProduct(CreateProductDto product);
        public void UpdateProduct(ProductDto product);
        public PaginatedList<ProductDto> GetProducts(int pageIndex, int pageSize);
        public void DeleteProduct(int id);
    }
}
