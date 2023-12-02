using BIT706_Assessment_2_Sean_Coster_5068788;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AssessmentTests
{
    [TestClass]
    public class InvestmentTests
    {

        // Constructor Tests
        [TestMethod]
        public void Constructor_InitialisesBalanceCorrectly()
        {
            // Arrange
            double expectedBalance = 1000.00;

            // Act
            Investment investment = new Investment(expectedBalance, 20, 0.05, false);

            // Assert
            Assert.AreEqual(expectedBalance, investment.Balance);
        }

        [TestMethod]
        public void Constructor_InitialisesFailedTransFeeCorrectly_ForNonStaff()
        {
            // Arrange
            double expectedFee = 20.00;

            // Act
            Investment investment = new Investment(1000.00, expectedFee, 0.05, false);

            // Assert
            Assert.AreEqual(expectedFee, investment.FailedTransFeeAmount);
        }

        [TestMethod]
        public void Constructor_InitialisesFailedTransFeeCorrectly_ForStaff()
        {
            // Arrange
            double inputFee = 20.00;
            double expectedFee = 10.00;  // Because isStaff is true, the fee is halved

            // Act
            Investment investment = new Investment(1000.00, inputFee, 0.05, true);

            // Assert
            Assert.AreEqual(expectedFee, investment.FailedTransFeeAmount);
        }

        [TestMethod]
        public void Constructor_InitialisesInterestRateCorrectly()
        {
            // Arrange
            double expectedRate = 0.05;

            // Act
            Investment investment = new Investment(1000.00, 20, expectedRate, false);

            // Assert
            Assert.AreEqual(expectedRate, investment.InterestRate);
        }


        // Method Tests
        [TestMethod]
        public void Deposit_AddsToBalance()
        {
            // Arrange
            double initialBalance = 1000.00;
            double depositAmount = 200.00;
            Investment investment = new Investment(initialBalance, 20, 0.05, false);

            // Act
            investment.Deposit(depositAmount);

            // Assert
            Assert.AreEqual(initialBalance + depositAmount, investment.Balance);
        }

        [TestMethod]
        [ExpectedException(typeof(WithdrawalException))]
        public void Withdraw_ThrowsException_WhenInsufficientFunds()
        {
            // Arrange
            Investment investment = new Investment(500.00, 20, 0.05, false);

            // Act
            investment.Withdraw(600.00);
        }

        [TestMethod]
        public void Withdraw_SubtractsFromBalance()
        {
            // Arrange
            double initialBalance = 1000.00;
            double withdrawalAmount = 200.00;
            Investment investment = new Investment(initialBalance, 20, 0.05, false);

            // Act
            investment.Withdraw(withdrawalAmount);

            // Assert
            Assert.AreEqual(initialBalance - withdrawalAmount, investment.Balance);
        }

        [TestMethod]
        public void DisplayInfo_ReturnsCorrectString()
        {
            // Arrange
            double balance = 1000.00;
            double fee = 20.00;
            double rate = 0.05;
            Investment investment = new Investment(balance, fee, rate, false);
            string expectedInfo = $"Account Type: Investment\nAccount Number: {investment.AccountNumber}\nBalance: {balance:C}\nFailed Transaction Fee: {fee:C} \n" +
                    $"Interest Rate: {rate:P}\n";

            // Act
            string actualInfo = investment.DisplayInfo();

            // Assert
            Assert.AreEqual(expectedInfo, actualInfo);
        }

        [TestMethod]
        public void CalculateInterest_AddsInterestToBalance()
        {
            // Arrange
            double initialBalance = 1000.00;
            double interestRate = 0.05;
            double expectedInterest = initialBalance * interestRate;
            Investment investment = new Investment(initialBalance, 20, interestRate, false);

            // Act
            investment.CalculateInterest();

            // Assert
            Assert.AreEqual(initialBalance + expectedInterest, investment.Balance);
        }
    }
}
