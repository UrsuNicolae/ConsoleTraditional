using ConsoleAppTraditional.Exceptions;

namespace ConsoleAppTraditional
{
    class BankAccount
    {
        public int AccountNumber { get; set; }
        public string AccountHolderName { get; set; }
        public decimal Balance { get; set; }
        public DateTime OpeningDate { get; set; }

        public BankAccount(int accountNumber,
            string accountHolder,
            decimal balance,
            DateTime openingDate)
        {
            AccountHolderName = accountHolder;
            AccountNumber = accountNumber;
            Balance = balance;
            OpeningDate = openingDate;
        }

        public static BankAccount OpenAccount(int accountNumber,
            string accountHolder,
            decimal balance,
            DateTime openingDate)
        {
            return new BankAccount(accountNumber,
            accountHolder,
            balance,
            openingDate);
        }

        public void DisplayAccountDetails()
        {
            Console.WriteLine($"AccountName:{AccountHolderName}" +
                $"\nAccountNumber:{AccountNumber}" +
                $"\nBalance:{Balance}" +
                $"\nOpeningDate:{OpeningDate}");
        }

        public void Depozit(int amount)
        {
            Balance += amount;
        }

        public void Widraw(int amount)
        {
            if(amount > Balance)
            {
              throw new InsuficientAmountException("Mijloace insuficiente!");
            }
            Balance -= amount;
        }
    }
}
