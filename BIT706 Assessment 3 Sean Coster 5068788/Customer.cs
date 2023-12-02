using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT706_Assessment_2_Sean_Coster_5068788
{
    public class Customer
    {

        // Initial customer number
        private static int lastCustomerNumber = 0;

        // Fields
        private int customerNumber;
        private string name;
        private string phoneNumber;
        private string emailAddress;

        // A list of Account objects associated with the customer
        private List<Account> accounts;

        // Constructor
        public Customer(string name, string phoneNumber, string emailAddress)
        {
            this.customerNumber = GenerateUniqueCustomerNumber();
            this.name = name;
            this.phoneNumber = phoneNumber;
            this.emailAddress = emailAddress;

            accounts = new List<Account>();
        }

        // Properties
        public int CustomerNumber
        {
            get { return customerNumber; }
            set { customerNumber = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public string EmailAddress
        {
            get { return emailAddress; }
            set { emailAddress = value; }
        }

        // Access the list of accounts
        public List<Account> Accounts
        {
            get { return accounts; }
        }

        // Add an account to the customer's list of accounts
        public void AddAccount(Account account)
        {
            accounts.Add(account);
        }

        // Generate a unique Customer number
        private int GenerateUniqueCustomerNumber()
        {
            lastCustomerNumber++; // Increment the account number
            return lastCustomerNumber;
        }

    }
}
