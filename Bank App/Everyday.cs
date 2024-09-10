using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT706_Assessment_3_Sean_Coster_5068788
{

    [Serializable]
    public class Everyday : Account
    {
        // Constructor
        public Everyday(double balance)
            : base(balance)
        {
            // No additional attributes
        }

        // Methods

        // Display Info
        public override string DisplayInfo()
        {
            return $"Account Type: Everyday\nAccount Number: {accountNumber}\nBalance: {balance:C}\n";
        }

        // Make Deposit
        public override string Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                return "Everyday account: " + accountNumber + " \nDeposited: $" + amount + ". \nNew balance: " + balance.ToString("C");
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
                return "Everyday account: " + accountNumber + " \nWithdrew: $" + amount + ". \nNew balance: " + balance.ToString("C");
            }
            else
            {
                // Throw exception for a failed withdrawal
                throw new WithdrawalException("Everyday", amount, balance);
            }
        }

        public override string CalculateInterest()
        {
            return "Everyday account does not gain interest!";
        }
    }
}