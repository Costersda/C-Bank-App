using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT706_Assessment_3_Sean_Coster_5068788
{
    [Serializable]
    public class Omni : Account
    {
        // Additional Fields
        private double failedTransFeeAmount;
        private double interestRate;
        private double overdraftLimit;
        private bool isStaff;

        // Constructor
        public Omni(double balance, double failedTransFeeAmount, double interestRate, double overdraftLimit, bool isStaff)
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
            this.overdraftLimit = overdraftLimit;
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

        public double OverdraftLimit
        {
            get { return overdraftLimit; }
            set { overdraftLimit = value; }
        }

        // Implementation of the methods

        // Display Account Info
        public override string DisplayInfo()
        {
            return $"Account Type: Omni\nAccount Number: {accountNumber}\nBalance: {balance:C}\nFailed Transaction Fee: {failedTransFeeAmount:C}\n" +
                $"Interest Rate: {interestRate:P}\nOverdraft Limit: {overdraftLimit:C}\nStaff member: {isStaff}\n";
        }

        // Make Deposit
        public override string Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                return "Omni account: " + accountNumber + " \nDeposited: $" + amount + ". \nNew balance: $" + balance;
            }
            else
            {
                return "You can only deposit positive amounts";
            }

        }


        // Make Withdrawal
        public override string Withdraw(double amount)
        {
            if (balance - amount >= -overdraftLimit)
            {
                balance -= amount;
                // Withdrawal successful
                return "Omni account: " + accountNumber + " \nWithdrew: $" + amount + ". \nNew balance: $" + balance;
            }
            else
            {
                // Deduct a fixed fee for failed transaction
                balance -= failedTransFeeAmount;

                // Throw exception for a failed withdrawal
                throw new WithdrawalException("Omni", amount, balance);
            }
        }

        // Calculate and add interest to the balance
        public override string CalculateInterest()
        {
            // Calculate interest based on the balance and interest rate (if balance is over $1000)
            if (balance > 1000)
            {
                double interest = (balance - 1000) * interestRate;
                balance += interest;
                return interestRate + "% Interest rate applied on Omni Account.\nNew balance: $" + balance;
            }
            else
                return "Omni Account Balances less than $1000 do not gain interest!";
        }
    }
}
