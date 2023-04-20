using BankAccountNS;
using System.Security.Cryptography.X509Certificates;


namespace BankTests
{
    [TestClass]
    public class BankAccountTests
    {

        [TestMethod]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            BankCustomer customer = new BankCustomer("Mr. Bryan Walton", beginningBalance);

            // Act
            customer.Accounts[0].Debit(debitAmount);

            // Assert
            double actual = customer.Accounts[0].Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }


        [TestMethod]
        public void Debit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = -100.00;
            BankCustomer customer = new BankCustomer("Mr. Bryan Walton", beginningBalance);

            // Act and assert
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => customer.Accounts[0].Debit(debitAmount));

        }


        [TestMethod]
        public void Debit_WhenAmountIsMoreThanBalance_ShouldThrowArgumentOutOfRange()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = 20.0;
            BankCustomer customer = new BankCustomer("Mr. Bryan Walton", beginningBalance);

            // Act
            try
            {
                customer.Accounts[0].Debit(debitAmount);
            }
            catch (System.ArgumentOutOfRangeException e)
            {
                // Assert
                StringAssert.Contains(e.Message, BankAccount.DebitAmountExceedsBalanceMessage);
                return;
            }

            Assert.Fail("The expected exception was not thrown.");
        }


        [TestMethod]
        public void Credit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange()
        {
            // Arrange
            double beginningBalance = 10.5;
            double creditAmount = -100.00;
            BankCustomer customer = new BankCustomer("Mr. Bryan Walton", beginningBalance);

            // Act
            try
            {
                customer.Accounts[0].Credit(creditAmount);

            }
            catch (System.ArgumentOutOfRangeException e)
            {
                // Assert
                StringAssert.Contains(e.Message, BankAccount.CreditAmountLessThanZeroMessage);
                return;
            }

            Assert.Fail("The expected exception was not thrown.");
        }


        [TestMethod]
        public void Debit_WhenBalanceIsLessThanZero_ShouldThrowArgumentOutOfBounds()
        {
            // Arrange
            double beginningBalance = -5.3;
            double debitAmount = 8.0;
            BankCustomer customer = new BankCustomer("Test customer", beginningBalance);

            // Act & Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => customer.Accounts[0].Debit(debitAmount), "Debit amount exceeds balance.");
        }

        [TestMethod]
        public void AddAccount_ShouldAddNewAccountWithGivenBalance()
        {
            // Arrange
            double initialBalance = 1000.0;
            double newAccountBalance = 500.0;
            BankCustomer customer = new BankCustomer("John Smith", initialBalance);

            // Act
            customer.AddAccount(newAccountBalance);

            // Assert
            Assert.AreEqual(2, customer.Accounts.Count);
            Assert.AreEqual(newAccountBalance, customer.Accounts[1].Balance);
        }

        [TestMethod]
        public void CloseAccount_ShouldRemoveExistingAccount()
        {
            // Arrange
            double initialBalance = 1000.0;
            BankCustomer customer = new BankCustomer("John Smith", initialBalance);
            BankAccount accountToRemove = customer.Accounts[0];

            // Act
            customer.CloseAccount(accountToRemove);

            // Assert
            Assert.AreEqual(0, customer.Accounts.Count);
        }
    }
}