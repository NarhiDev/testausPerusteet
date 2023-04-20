using System;

namespace BankAccountNS
{
    class Program
    {
        static void Main(string[] args)
        {
            BankCustomer customer = new BankCustomer("Mr. Bryan Walton", 11.99);
            customer.AddAccount(1000.0);

            customer.Accounts[0].Credit(5.77);
            customer.Accounts[0].Debit(11.22);
            Console.WriteLine("Customer {0} has a balance of ${1} in account 1", customer.CustomerName, customer.Accounts[0].Balance);

            customer.Accounts[1].Credit(500.0);
            customer.Accounts[1].Debit(100.0);
            Console.WriteLine("Customer {0} has a balance of ${1} in account 2", customer.CustomerName, customer.Accounts[1].Balance);

            customer.CloseAccount(customer.Accounts[1]);

        }
    }
}
