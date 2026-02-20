namespace ConsoleAppTraditional.Class
{
    public interface IPaymentProcessor
    {
        void ProcessPayment(double amount);
    }

    public interface IPaymentDetails
    {
        void DisplayPaymentDetails();
    }


    public class CreditCardPayment : IPaymentDetails, IPaymentProcessor
    {
        private static int lastPaymentId = 0;
        public int PaymentId { get; private set; }

        public double Amount { get; set; }

        public string CreditCardNumber { get; private set; }

        public CreditCardPayment(double amount, string creditCardNumber)
        {
            Amount = amount;
            CreditCardNumber = creditCardNumber;
            PaymentId = GeneratePaymentId();
        }

        private int GeneratePaymentId()
        {
            return ++lastPaymentId;
        }

        public void DisplayPaymentDetails()
        {
            Console.WriteLine($"Payment ID: {PaymentId}");
            Console.WriteLine($"Amount: {Amount}");
            Console.WriteLine($"CreditCardNumber: {CreditCardNumber}");
        }

        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing credit card payment of {Amount:C2} with card number: {CreditCardNumber}");
            //logic of processing api calls, db calls
            Console.WriteLine("Credit card payment process successfully!");
        }
    }

    public class PayPalPayment : IPaymentDetails, IPaymentProcessor
    {
        private static int lastPaymentId = 0;
        public int PaymentId { get; private set; }

        public double Amount { get; set; }

        public string PayPalEmail { get; private set; }

        public PayPalPayment(double amount, string creditCardNumber)
        {
            Amount = amount;
            PayPalEmail = creditCardNumber;
            PaymentId = GeneratePaymentId();
        }

        private int GeneratePaymentId()
        {
            return ++lastPaymentId;
        }

        public void DisplayPaymentDetails()
        {
            Console.WriteLine($"Payment ID: {PaymentId}");
            Console.WriteLine($"Amount: {Amount}");
            Console.WriteLine($"Email: {PayPalEmail}");
        }

        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing PayPal payment of {Amount:C2} with card number: {PayPalEmail}");
            //logic of processing api calls, db calls
            Console.WriteLine("PayPal payment process successfully!");
        }
    }
}
