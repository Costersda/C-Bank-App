using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT706_Assessment_3_Sean_Coster_5068788
{
    public class CustomerController
    {
        private List<Customer> customers; // In memory customer database

        // Constructor
        public CustomerController()
        {
            customers = new List<Customer>();
        }

        public List<Customer> GetCustomers()
        {
            return customers;
        }

        public Customer GetCustomerByIndex(int index)
        {
            // Check if the index is valid before accessing the list.
            if (index >= 0 && index < customers.Count)
            {
                return customers[index];
            }
            return null; // Return null if the index is out of range.
        }

        // Add a customer to the list of customers
        public void AddCustomer(string name, string phoneNumber, string emailAddress)
        {
            Customer customer = new Customer(name, phoneNumber, emailAddress);
            customers.Add(customer);
        }

        // Find a customer by their customer number
        public Customer FindCustomerByNumber(int customerNumber)
        {
            return customers.FirstOrDefault(c => c.CustomerNumber == customerNumber);
        }

        // Edit an existing customer's details using their customer number as a reference
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

        // Delete a customer using their customer number
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
    }
}
