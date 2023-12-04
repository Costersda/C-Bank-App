using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT706_Assessment_3_Sean_Coster_5068788
{
    public class Investment : Account
    {
        // Additional Fields
        private double failedTransFeeAmount;
        private double interestRate;
        private bool isStaff;

        // Constructor
        public Investment(double balance, double failedTransFeeAmount, double interestRate, bool isStaff)
            : base(balance)
        {
            if (isStaff)
            {
                this.failedTransFeeAmount = failedTransFeeAmount / 2;
            }
            else
            {
                this.failedTransFeeAmount = failedTransFeeAmount;
            }
            this.interestRate = interestRate;
            this.isStaff = isStaff;
        }

        // Properties
        public double FailedTransFeeAmount
        {
            get { return failedTransFeeAmount; }
            set { failedTransFeeAmount = value; }
        }

        public double InterestRate
        {
            get { return interestRate; }
            set { interestRate = value; }
        }

        // Implementation of the methods

        // Display Account Info
        public override string DisplayInfo()
        {
            return $"Account Type: Investment\nAccount Number: {accountNumber}\nBalance: {balance:C}\nFailed Transaction Fee: {failedTransFeeAmount:C} \n" +
                $"Interest Rate: {interestRate:P}\n";
        }

        // Make Deposit
        public override string Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                return "Investment account: " + accountNumber + " \nDeposited: $" + amount + ". \nNew balance: $" + balance;
            }
            else
            {
                return "You can only deposit positive amounts";
            }

        }

        // Make Withdrawal
        public override string Withdraw(double amount)
        {
            if (balance - amount >= 0)
            {
                balance -= amount;
                // Withdrawal successful
                return "Investment account: " + accountNumber + " \nWithdrew: $" + amount + ". \nNew balance: $" + balance;
            }
            else
            {
                // Deduct fixed fee for failed transaction
                balance -= failedTransFeeAmount;

                // Throw exception for a failed withdrawal
                throw new WithdrawalException("Investment", amount, balance);
            }
        }

        // Calculate and add interest to the balance
        public override string CalculateInterest()
        {
            // Calculate interest based on the balance and interest rate
            double interest = balance * interestRate;
            balance += interest;
            return interestRate + "% Interest rate applied to Investment Account. \nNew balance: $" + balance;
        }
    }
}
