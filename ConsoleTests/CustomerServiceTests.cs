using ConsoleAppTraditional.UTs;
using Moq;

namespace ConsoleTests
{
    public class CustomerServiceTests
    {
        [Fact]
        public void CustomerServiceShouldReturnCustomerNameByCustomerIdIfCustomerExists()
        {
            //
            var exxpectedCustomer = new Customer { CustomerId = 1, Name = "Nicole" };
            var customerRepositoryMock = new Mock<ICustomerRepository>();
            customerRepositoryMock.Setup(_ => _.GetCustomerById(It.IsAny<int>())).Returns(exxpectedCustomer);
            var customerService = new CustomerService(customerRepositoryMock.Object);
            var customer = customerService.GetCustomerName(2);
            //
            customerRepositoryMock.Verify(_ => _.GetCustomerById(It.IsAny<int>()), Times.Once);
            Assert.Equal(exxpectedCustomer.Name, customer);
        }

        [Fact]
        public void CustomerServiceShouldReturnUnknowIfCustomerNotExists()
        {
            //
            var expectedName = "Unknown";
            var customerRepositoryMock = new Mock<ICustomerRepository>();
            var customerService = new CustomerService(customerRepositoryMock.Object);
            var customer = customerService.GetCustomerName(2);
            //
            customerRepositoryMock.Verify(_ => _.GetCustomerById(It.IsAny<int>()), Times.Once);
            Assert.Equal(expected: expectedName, customer);
        }
    }
}
