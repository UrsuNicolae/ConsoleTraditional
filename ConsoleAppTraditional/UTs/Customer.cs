namespace ConsoleAppTraditional.UTs
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        // ... alte proprietăți
    }


    public interface ICustomerRepository
    {
        Customer GetCustomerById(int customerId);
    }


    public class CustomerService
    {
        private ICustomerRepository _customerRepository;


        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }


        public string GetCustomerName(int customerId)
        {
            var customer = _customerRepository.GetCustomerById(customerId);
            return customer?.Name ?? "Unknown";
        }
    }

}
