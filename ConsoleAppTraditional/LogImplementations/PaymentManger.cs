namespace ConsoleAppTraditional.LogImplementations
{
    public class PaymentManger
    {
        private readonly ILogger logger;

        public PaymentManger(ILogger logger)
        {
            this.logger = logger;
        }

        public void ProcessPayment(double amount, string creditCard)
        {
            if (IsValidCardNumber(creditCard))
            {
                logger.LogInformation($"Processed payment of {amount} for card {creditCard}");
            }
            else
            {
                logger.LogError($"Invalid credit card number: {creditCard}");
            }
        }

        public void RefundPayment(double amount, string transactionId)
        {
            if (IsValidTransaction(transactionId))
            {
                logger.LogInformation($"Transaction: {transactionId} refunded amount: {amount}");
            }
            else
            {
                logger.LogError($"Transaction invalid, invalid id: {transactionId}");
            }
        }

        public void ProcessRefund(double amount, string transactionId)
        {
            if (IsValidTransaction(transactionId))
            {
                logger.LogInformation($"Transaction: {transactionId} refunded amount: {amount}");
            }
            else
            {
                logger.LogWarning($"Attempted to process refund for invalid transactionId: {transactionId}");
            }
        }

        private bool IsValidCardNumber(string creditCardNumber)
        {
            return creditCardNumber.Length == 16;
        }

        private bool IsValidTransaction(string transactionId)
        {
            return transactionId.Length == 10;
        }
    }
}
