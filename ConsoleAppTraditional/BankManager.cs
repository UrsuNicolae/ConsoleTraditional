namespace ConsoleAppTraditional
{
    struct BankManager
    {
        private List<BankAccount> accounts = new ();
        public BankManager()
        {
            
        }

        public void AddNewAccount(BankAccount acc)
        {
            accounts.Add(acc);
        }

        public void DisplayAll()
        {
            foreach(var acc in accounts)
            {
                acc.DisplayAccountDetails();
            }
        }

        public BankAccount? FindById(int accNr)
        {
            BankAccount? acount = null;
            foreach (var acc in accounts)
            {
                if(acc.AccountNumber == accNr)
                {
                    acount = acc;
                    break;
                }
            }
            return acount;
        }

        public void DeleteById(int accNr)
        {
            BankAccount? acount = null;
            foreach (var acc in accounts)
            {
                if (acc.AccountNumber == accNr)
                {
                    acount = acc;
                    break;
                }
            }

            if(acount != null)
            {
                accounts.Remove((BankAccount)acount);
            }
        }
    }
}
