using BIT706_Assessment_3_Sean_Coster_5068788;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AssessmentTests
{
    [TestClass]
    public class AccountTests
    {
        [TestMethod]
        public void Constructor_SetsBalanceCorrectly()
        {
            // Arrange
            double expectedBalance = 100.00;

            // Act
            MockAccount account = new MockAccount(expectedBalance); // MockAccount is a class for testing since Account is abstract

            // Assert
            Assert.AreEqual(expectedBalance, account.Balance);
        }

        [TestMethod]
        public void Constructor_GeneratesUniqueAccountNumber()
        {
            // Arrange
            MockAccount account1 = new MockAccount(100.00);
            MockAccount account2 = new MockAccount(150.00);

            // Act
            int accountNumberDifference = account2.AccountNumber - account1.AccountNumber;

            // Assert
            Assert.AreEqual(1, accountNumberDifference);
        }
    }

    // Concrete class derived from Account for testing
    public class MockAccount : Account
    {
        public MockAccount(double balance) : base(balance) { }

        public override string Deposit(double amount) => string.Empty;

        public override string Withdraw(double amount) => string.Empty;

        public override string DisplayInfo() => string.Empty;

        public override string CalculateInterest() => string.Empty;
    }
}
