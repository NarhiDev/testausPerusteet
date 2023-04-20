namespace BankAccountNS
{
    public class BankCustomer
    {
        private readonly string m_customerName;
        private List<BankAccount> m_accounts;

        public BankCustomer(string customerName, double balance)
        {
            m_customerName = customerName;
            m_accounts = new List<BankAccount>() { new BankAccount(balance) };
        }

        public string CustomerName
        {
            get { return m_customerName; }
        }

        public List<BankAccount> Accounts
        {
            get { return m_accounts; }
        }
        public void AddAccount(double balance)
        {
            m_accounts.Add(new BankAccount(balance));
            Console.WriteLine("Account added!");
        }

        public void CloseAccount(BankAccount account)
        {
            m_accounts.Remove(account);
            Console.WriteLine("Account closed!");
        }
    }
}
