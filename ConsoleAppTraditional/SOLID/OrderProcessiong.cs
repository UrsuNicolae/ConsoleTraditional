using ConsoleAppTraditional.LogImplementations;
using System.Net.Mail;

namespace ConsoleAppTraditional.SOLID
{
    class Order
    {
        public string CustomerName { get; set; }
        public double OrderAmount { get; set; }
        public int OrderId { get; set; }
    }

    interface IOrderValidtor
    {
        void Validate(Order order);
    }

    class OrderValidator : IOrderValidtor
    {
        public void Validate(Order order)
        {
            if (order == null)
            {
                throw new ArgumentNullException(nameof(order));
            }

            if (string.IsNullOrWhiteSpace(order.CustomerName))
            {
                throw new InvalidOperationException("Customer name is required.");
            }

            if (order.OrderAmount <= 0)
            {
                throw new InvalidOperationException("Order amount must be greater than zero.");
            }
        }
    }

    interface IPaymentProcessor
    {
        void ProcessPayment(Order order);
    }

    class PaymentProcessor : IPaymentProcessor
    {
        public void ProcessPayment(Order order)
        {
            string paymentId = Guid.NewGuid().ToString();
            DateTime paymentDate = DateTime.Now;

            Console.WriteLine($"Payment {paymentId} processed for order {order.OrderId} on {paymentDate}");
        }
    }

    interface IInvoiceGenerator
    {
        void GenerateInvoice(Order order);
    }

    class InvoiceGenerator : IInvoiceGenerator
    {
        public void GenerateInvoice(Order order)
        {
            string invoice = $"INVOICE\nOrder ID: {order.OrderId}\nCustomer: {order.CustomerName}\nAmount: {order.OrderAmount}\nDate: {DateTime.Now}";
            string path = $"invoice_{order.OrderId}.txt";

            File.WriteAllText(path, invoice);

            Console.WriteLine($"Invoice saved to {path}");

        }
    }


    interface ICustomerNotifier
    {
        void Notify(Order order);
    }

    class CustomerNotifier : ICustomerNotifier
    {
        public void Notify(Order order)
        {

            try
            {
                MailMessage message = new MailMessage("shop@example.com", "customer@example.com");
                message.Subject = $"Order Confirmation #{order.OrderId}";
                message.Body = $"Hello {order.CustomerName}, your order was processed successfully. Amount: {order.OrderAmount}";

                SmtpClient client = new SmtpClient("smtp.example.com");
                client.Send(message);

                Console.WriteLine("Email notification sent.");
            }
            catch
            {
                Console.WriteLine("Failed to send email notification.");
            }

        }
    }

    class OrderProcessing
    {
        private readonly IOrderValidtor orderValidator;
        private readonly IPaymentProcessor paymentProcessor;
        private readonly IInvoiceGenerator invoiceGenerator;
        private readonly ICustomerNotifier customerNotifier;
        private readonly ILogger logger;

        public OrderProcessing(IOrderValidtor orderValidator,
            IPaymentProcessor paymentProcessor,
            IInvoiceGenerator invoiceGenerator,
            ICustomerNotifier customerNotifier, 
            ILogger logger)
        {
            this.orderValidator = orderValidator;
            this.paymentProcessor = paymentProcessor;
            this.invoiceGenerator = invoiceGenerator;
            this.customerNotifier = customerNotifier;
            this.logger = logger;
        }
        public void ProcessOrder(Order order)
        {
            orderValidator.Validate(order);

            paymentProcessor.ProcessPayment(order);

            invoiceGenerator.GenerateInvoice(order);
            customerNotifier.Notify(order);

            logger.LogInformation($"[{DateTime.Now}] Order {order.OrderId} processed for {order.CustomerName} amount {order.OrderAmount}\n");
        }
    }
}
