using System;

namespace BankAccountNS
{
    class Program
    {

        static void Main(string[] args)
        {

            BankCustomer customer1 = new BankCustomer("customer1", 1000.0);
            customer1.AddAccount(1000.0);
            Console.WriteLine("Customer1's balance is {0} euros.", customer1.Accounts[0].Balance);

            BankCustomer customer2 = new BankCustomer("customer2", 500.0);
            customer2.AddAccount(500.0);
            Console.WriteLine("Customer2's balance is {0} euros.", customer2.Accounts[0].Balance);

            BankAccount customeraccount1 = customer1.Accounts[0];
            BankAccount customeraccount2 = customer2.Accounts[0];
            double amount = 500.0;
            BankAccount.Transfer(customeraccount1, customeraccount2, amount);

            Console.WriteLine("Customer1's balance is now {0} euros.", customer1.Accounts[0].Balance);
            Console.WriteLine("Customer2's balance is now {0} euros.", customer2.Accounts[0].Balance);

            try
            {
                amount = 1000.0;
                BankAccount.Transfer(customeraccount1, customeraccount2, amount);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                amount = -500.0;
                BankAccount.Transfer(customeraccount1, customeraccount2, amount);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                customeraccount1 = customer1.Accounts[0];
                customeraccount2 = customer2.Accounts[0];
                amount = 1000.0;
                BankAccount.Transfer(customeraccount1, customeraccount2, amount);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }

            customer1.CloseAccount(customer1.Accounts[0]);
        }
    }
}
