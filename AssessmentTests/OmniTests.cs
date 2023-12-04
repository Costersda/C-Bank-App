using BIT706_Assessment_3_Sean_Coster_5068788;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AssessmentTests
{
    [TestClass]
    public class OmniTests
    {
        // Constructor Tests
        [TestMethod]
        public void Constructor_InitialisesBalanceCorrectly()
        {
            // Arrange
            double expectedBalance = 1000.00;

            // Act
            Omni omni = new Omni(expectedBalance, 20.00, 0.05, 100.00, false);

            // Assert
            Assert.AreEqual(expectedBalance, omni.Balance);
        }

        [TestMethod]
        public void Constructor_InitialisesFailedTransFeeCorrectly_ForNonStaff()
        {
            // Arrange
            double expectedFee = 20.00;

            // Act
            Omni omni = new Omni(1000.00, expectedFee, 0.05, 100.00, false);

            // Assert
            Assert.AreEqual(expectedFee, omni.FailedTransFeeAmount);
        }

        [TestMethod]
        public void Constructor_InitialisesFailedTransFeeCorrectly_ForStaff()
        {
            // Arrange
            double inputFee = 20.00;
            double expectedFee = 10.00;  // Because isStaff is true, the fee is halved

            // Act
            Omni omni = new Omni(1000.00, inputFee, 0.05, 100.00, true);

            // Assert
            Assert.AreEqual(expectedFee, omni.FailedTransFeeAmount);
        }

        [TestMethod]
        public void Constructor_InitialisesInterestRateCorrectly()
        {
            // Arrange
            double expectedRate = 0.05;

            // Act
            Omni omni = new Omni(1000.00, 20.00, expectedRate, 100.00, false);

            // Assert
            Assert.AreEqual(expectedRate, omni.InterestRate);
        }

        [TestMethod]
        public void Constructor_InitialisesOverdraftLimitCorrectly()
        {
            // Arrange
            double expectedLimit = 100.00;

            // Act
            Omni omni = new Omni(1000.00, 20.00, 0.05, expectedLimit, false);

            // Assert
            Assert.AreEqual(expectedLimit, omni.OverdraftLimit);
        }

        // Method Tests
        [TestMethod]
        public void Deposit_PositiveAmount_IncreasesBalance()
        {
            // Arrange
            Omni omni = new Omni(1000.00, 20.00, 0.05, 100.00, false);
            double depositAmount = 200.00;
            double expectedBalance = 1200.00;

            // Act
            omni.Deposit(depositAmount);

            // Assert
            Assert.AreEqual(expectedBalance, omni.Balance);
        }

        [TestMethod]
        public void Deposit_NegativeAmount_ReturnsErrorMessage()
        {
            // Arrange
            Omni omni = new Omni(1000.00, 20.00, 0.05, 100.00, false);
            double depositAmount = -200.00;
            string expectedMessage = "You can only deposit positive amounts";

            // Act
            string resultMessage = omni.Deposit(depositAmount);

            // Assert
            Assert.AreEqual(expectedMessage, resultMessage);
        }

        [TestMethod]
        public void Withdraw_WithinBalance_DecreasesBalance()
        {
            // Arrange
            Omni omni = new Omni(1000.00, 20.00, 0.05, 100.00, false);
            double withdrawalAmount = 200.00;
            double expectedBalance = 800.00;

            // Act
            omni.Withdraw(withdrawalAmount);

            // Assert
            Assert.AreEqual(expectedBalance, omni.Balance);
        }

        [TestMethod]
        public void Withdraw_WithinOverdraftLimit_DecreasesBalance()
        {
            // Arrange
            Omni omni = new Omni(1000.00, 20.00, 0.05, 100.00, false);
            double withdrawalAmount = 1100.00;
            double expectedBalance = -100.00;

            // Act
            omni.Withdraw(withdrawalAmount);

            // Assert
            Assert.AreEqual(expectedBalance, omni.Balance);
        }

        [TestMethod]
        [ExpectedException(typeof(WithdrawalException))]
        public void Withdraw_ExceedingOverdraftLimit_ThrowsException()
        {
            // Arrange
            Omni omni = new Omni(1000.00, 20.00, 0.05, 100.00, false);
            double withdrawalAmount = 1150.00;

            // Act
            omni.Withdraw(withdrawalAmount);

        }

        [TestMethod]
        public void CalculateInterest_BalanceOverThreshold_IncreasesBalance()
        {
            // Arrange
            Omni omni = new Omni(1100.00, 20.00, 0.05, 100.00, false);
            double expectedBalance = 1100.00 + 100.00 * 0.05;

            // Act
            omni.CalculateInterest();

            // Assert
            Assert.AreEqual(expectedBalance, omni.Balance);
        }

        [TestMethod]
        public void CalculateInterest_BalanceUnderThreshold_ReturnsMessage()
        {
            // Arrange
            Omni omni = new Omni(900.00, 20.00, 0.05, 100.00, false);
            string expectedMessage = "Omni Account Balances less than $1000 do not gain interest!";

            // Act
            string resultMessage = omni.CalculateInterest();

            // Assert
            Assert.AreEqual(expectedMessage, resultMessage);
        }
    }
}
