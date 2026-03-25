using ConsoleAppTraditional.UTs;
using Moq;

namespace ConsoleTests
{
    public class ShoppingCartTests
    {
        [Fact]
        public void ShoppingCartSumShouldBeZeroIfNoItemsInCart()
        {
            var productRepoMock = new Mock<IProductRepository>();
            var shoppingCart = new ShoppingCart(productRepoMock.Object);

            var total = shoppingCart.CalculateTotal();
            productRepoMock.Verify(_ => _.GetProductById(It.IsAny<int>()), Times.Never);
            Assert.Equal(0, total);
        }

        [Fact]
        public void ShoppingCartSumShouldIncreaseIfWeAddItemsInCart()
        {
            var firstProduct = new Product
            {
                ProductId = 1,
                Price = 20,
                Name = "First"
            };
            var productRepoMock = new Mock<IProductRepository>();
            productRepoMock.Setup(_ => _.GetProductById(firstProduct.ProductId)).Returns(firstProduct);
            var shoppingCart = new ShoppingCart(productRepoMock.Object);

            var total = shoppingCart.CalculateTotal();
            productRepoMock.Verify(_ => _.GetProductById(firstProduct.ProductId), Times.Never);
            Assert.Equal(0, total);

            shoppingCart.AddToCart(firstProduct.ProductId);
            total = shoppingCart.CalculateTotal();
            productRepoMock.Verify(_ => _.GetProductById(firstProduct.ProductId), Times.Once);
            Assert.Equal(firstProduct.Price, total);
        }
    }
}
