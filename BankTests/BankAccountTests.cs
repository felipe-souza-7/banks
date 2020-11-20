using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bank;

namespace BankTests
{
    [TestClass]
    public class BankAccountTests
    {
        [TestMethod]
        public void Debit_WithValidAmount_UpdateBalance()
        {
            //Arrange
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            bankAccount account = new bankAccount("Felipe", beginningBalance);
            //Act
            account.Debit(debitAmount);
            //Assert
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, "Débito não ocorreu corretamente.");
        }

        [TestMethod]
        public void Debit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRanger()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = -100.00;
            bankAccount account = new bankAccount("Felipe", beginningBalance);
            // Act and assert
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(()=>account.Debit((debitAmount)));
        }

        [TestMethod]
        public void Credit_WithValidAmount_UpdateBalance()
        {
            //arrange
            double beginnigBalance = 100.00;
            double creditAmount = 40.00;
            double expected = 140.00;
            bankAccount account = new bankAccount("Felipe", beginnigBalance);
            //Act
            account.Credit(creditAmount);
            //Assert
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, "Crédito não ocorreu corretamente.");
        }

        [TestMethod]
        public void Credit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRanger()
        {
            //Arrange
            double beginnigBalance = 100.00;
            double creditAmount = 40.00;
            bankAccount account = new bankAccount("Felipe", beginnigBalance);
            // Act and assert
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => account.Credit((creditAmount)));
        }
    }   


}
