using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT706_Assessment_3_Sean_Coster_5068788
{
    [Serializable]
    public abstract class Account
    {
        // Initial account number
        private static int lastAccountNumber = 0;

        // Fields
        protected int accountNumber;
        protected double balance;

        // The account owning customer
        public Customer Customer { get; set; }

        // Constructor
        public Account(double balance)
        {
            this.accountNumber = GenerateUniqueAccountNumber();
            this.balance = balance;
        }

        // Properties
        public int AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        // Generate a unique account number
        private int GenerateUniqueAccountNumber()
        {
            lastAccountNumber++; // Increment the account number
            return lastAccountNumber;
        }

        public static int LastAccountNumber
        {
            get { return lastAccountNumber; }
            set { lastAccountNumber = value; }
        }

        // Abstract Methods
        public abstract string Deposit(double amount);

        public abstract string Withdraw(double amount);

        public abstract string DisplayInfo();

        public abstract string CalculateInterest();
    }
}
