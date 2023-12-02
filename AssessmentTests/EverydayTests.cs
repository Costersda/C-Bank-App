using BIT706_Assessment_2_Sean_Coster_5068788;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AssessmentTests
{
    [TestClass]
    public class EverydayTests
    {
        // Constructor Tests
        [TestMethod]
        public void Constructor_InitialisesBalanceCorrectly()
        {
            // Arrange
            double expectedBalance = 1000.00;

            // Act
            Everyday everyday = new Everyday(expectedBalance);

            // Assert
            Assert.AreEqual(expectedBalance, everyday.Balance);
        }

        // Method Tests
        [TestMethod]
        public void Deposit_PositiveAmount_IncreasesBalance()
        {
            // Arrange
            double initialBalance = 1000.00;
            double depositAmount = 200.00;
            Everyday everyday = new Everyday(initialBalance);

            // Act
            everyday.Deposit(depositAmount);

            // Assert
            Assert.AreEqual(initialBalance + depositAmount, everyday.Balance);
        }

        [TestMethod]
        public void Deposit_NegativeAmount_ReturnsErrorMessage()
        {
            // Arrange
            Everyday everyday = new Everyday(1000.00);

            // Act
            string result = everyday.Deposit(-200.00);

            // Assert
            Assert.AreEqual("You can only deposit positive amounts", result);
        }

        [TestMethod]
        public void Withdraw_ValidAmount_DecreasesBalance()
        {
            // Arrange
            double initialBalance = 1000.00;
            double withdrawAmount = 200.00;
            Everyday everyday = new Everyday(initialBalance);

            // Act
            everyday.Withdraw(withdrawAmount);

            // Assert
            Assert.AreEqual(initialBalance - withdrawAmount, everyday.Balance);
        }

        [TestMethod]
        [ExpectedException(typeof(WithdrawalException))]
        public void Withdraw_AmountGreaterThanBalance_ThrowsWithdrawalException()
        {
            // Arrange
            Everyday everyday = new Everyday(1000.00);

            // Act
            everyday.Withdraw(1100.00);
        }

        [TestMethod]
        public void DisplayInfo_ReturnsCorrectString()
        {
            // Arrange
            double balance = 1000.00;
            Everyday everyday = new Everyday(balance);
            string expectedInfo = $"Account Type: Everyday\nAccount Number: {everyday.AccountNumber}\nBalance: {balance:C}\n";

            // Act
            string actualInfo = everyday.DisplayInfo();

            // Assert
            Assert.AreEqual(expectedInfo, actualInfo);
        }

        [TestMethod]
        public void CalculateInterest_ReturnsCorrectMessage()
        {
            // Arrange
            Everyday everyday = new Everyday(1000.00);

            // Act
            string result = everyday.CalculateInterest();

            // Assert
            Assert.AreEqual("Everyday account does not gain interest!", result);
        }
    }
}
