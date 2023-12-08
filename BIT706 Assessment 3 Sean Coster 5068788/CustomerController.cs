using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIT706_Assessment_3_Sean_Coster_5068788
{
    /// <summary>
    /// Manages customer-related operations such as adding, editing, and deleting customers, 
    /// as well as handling customer accounts including deposits, withdrawals, and transfers.
    /// </summary>

    [Serializable]
    public class CustomerController
    {
        private List<Customer> customers; // In memory customer database

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerController"/> class.
        /// </summary>
        public CustomerController()
        {
            customers = new List<Customer>();
        }

        /// <summary>
        /// Gets or sets the list of customers.
        /// </summary>
        public List<Customer> Customers
        {
            get { return customers; }
            set { customers = value; }
        }

        /// <summary>
        /// Retrieves a customer by their index in the list.
        /// </summary>
        /// <param name="index">The index of the customer in the list.</param>
        /// <returns>The customer at the specified index, or null if the index is out of range.</returns>
        public Customer GetCustomerByIndex(int index)
        {
            // Check if the index is valid before accessing the list.
            if (index >= 0 && index < customers.Count)
            {
                return customers[index];
            }
            return null; // Return null if the index is out of range.
        }

        /// <summary>
        /// Retrieves an account by its index from a specified customer.
        /// </summary>
        /// <param name="customer">The customer whose account is to be retrieved.</param>
        /// <param name="index">The index of the account in the customer's account list.</param>
        /// <returns>The account at the specified index, or null if the index is out of range.</returns>
        public Account GetAccountByIndex(Customer customer, int index)
        {
            // Check if the index is valid before accessing the list.
            if (index >= 0 && index < customer.Accounts.Count)
            {
                return customer.Accounts[index];
            }
            return null; // Return null if the index is out of range.
        }

        /// <summary>
        /// Adds a new customer to the list with the specified details.
        /// </summary>
        /// <param name="name">The name of the customer.</param>
        /// <param name="phoneNumber">The phone number of the customer.</param>
        /// <param name="emailAddress">The email address of the customer.</param>
        public void AddCustomer(string name, string phoneNumber, string emailAddress)
        {
            Customer customer = new Customer(name, phoneNumber, emailAddress);
            customers.Add(customer);
        }

        /// <summary>
        /// Adds a new staff member to the list of customers.
        /// </summary>
        /// <remarks>
        /// Note: Staff are treated as special types of customers.
        /// </remarks>
        /// <param name="name">The name of the staff member.</param>
        /// <param name="phoneNumber">The phone number of the staff member.</param>
        /// <param name="emailAddress">The email address of the staff member.</param>
        public void AddStaff(string name, string phoneNumber, string emailAddress)
        {
            Staff staff = new Staff(name, phoneNumber, emailAddress);
            customers.Add(staff);
        }

        /// <summary>
        /// Finds a customer by their unique customer number.
        /// </summary>
        /// <param name="customerNumber">The unique number of the customer.</param>
        /// <returns>The customer with the specified number, or null if no such customer is found.</returns>
        public Customer FindCustomerByNumber(int customerNumber)
        {
            return customers.FirstOrDefault(c => c.CustomerNumber == customerNumber);
        }

        /// <summary>
        /// Edits an existing customer's details.
        /// </summary>
        /// <param name="customerNumber">The unique number of the customer to be edited.</param>
        /// <param name="newName">The new name of the customer.</param>
        /// <param name="newPhoneNumber">The new phone number of the customer.</param>
        /// <param name="newEmailAddress">The new email address of the customer.</param>
        /// <returns>True if the customer was found and edited, false otherwise.</returns>
        public bool EditCustomer(int customerNumber, string newName, string newPhoneNumber, string newEmailAddress)
        {
            Customer customer = FindCustomerByNumber(customerNumber);
            if (customer != null)
            {
                customer.Name = newName;
                customer.PhoneNumber = newPhoneNumber;
                customer.EmailAddress = newEmailAddress;
                return true; // Edit successful
            }
            return false; // Customer not found
        }

        /// <summary>
        /// Deletes a customer using their unique customer number.
        /// </summary>
        /// <param name="customerNumber">The unique number of the customer to be deleted.</param>
        /// <returns>True if the customer was found and deleted, false otherwise.</returns>
        public bool DeleteCustomer(int customerNumber)
        {
            Customer customer = FindCustomerByNumber(customerNumber);
            if (customer != null)
            {
                customers.Remove(customer);
                return true; // Delete successful
            }
            return false; // Customer not found
        }

        /// <summary>
        /// Deposits a specified amount into a given account.
        /// </summary>
        /// <param name="account">The account where the amount is to be deposited.</param>
        /// <param name="amount">The amount to be deposited.</param>
        public void AccountDeposit(Account account, double amount)
        {
            account.Deposit(amount);
        }

        /// <summary>
        /// Withdraws a specified amount from a given account.
        /// </summary>
        /// <param name="account">The account from which the amount is to be withdrawn.</param>
        /// <param name="amount">The amount to be withdrawn.</param>
        public void AccountWithdraw(Account account, double amount)
        {
            account.Withdraw(amount);
        }

        /// <summary>
        /// Checks whether transferring money between two given accounts is valid.
        /// </summary>
        /// <param name="wthAccount">The account from which money is to be withdrawn.</param>
        /// <param name="dpstAccount">The account to which money is to be deposited.</param>
        /// <returns>True if the accounts are different and transfer is valid, false otherwise.</returns>
        public bool AccountTransferCheck(Account wthAccount, Account dpstAccount)
        {
            if (wthAccount.AccountNumber == dpstAccount.AccountNumber)
            {
                return false; // Accounts are the same
            }
            else
                return true; // Accounts are different
        }

        /// <summary>
        /// Transfers a specified amount of money from one account to another.
        /// </summary>
        /// <param name="wthAccount">The account from which the amount will be withdrawn.</param>
        /// <param name="dpstAccount">The account to which the amount will be deposited.</param>
        /// <param name="amount">The amount of money to transfer.</param>
        public void AccountTransfer(Account wthAccount, Account dpstAccount, double amount)
        {
            wthAccount.Withdraw(amount);
            dpstAccount.Deposit(amount);
        }

        /// <summary>
        /// Checks if a given customer is a staff member.
        /// </summary>
        /// <param name="customer">The customer to check.</param>
        /// <returns>True if the customer is a staff member, false otherwise.</returns>
        public bool IsStaffCheck(Customer customer)
        {
            if (customer.GetType().Name == "Staff")
            {
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Adds an account to a customer's list of accounts.
        /// </summary>
        /// <param name="customer">The customer to whom the account will be added.</param>
        /// <param name="account">The account to be added to the customer.</param>
        public void AddAccount(Customer customer, Account account)
        {
            customer.AddAccount(account);
        }

    }
}
