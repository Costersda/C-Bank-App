using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIT706_Assessment_3_Sean_Coster_5068788
{
    public partial class FormManageCustomers : FormBranding
    {

        // Constructor
        public FormManageCustomers()
        {
            InitializeComponent();
            labelSubTitle.Text = "Customers:"; // Set the subtitle
            LoadCustomersIntoListView();
        }

        private void LoadCustomersIntoListView()
        {
            listViewCustomers.Items.Clear(); // Clear the existing items
            foreach (var customer in customerController.GetCustomers())
            {
                var item = new ListViewItem(customer.CustomerNumber.ToString()); // The CustomerNumber as the primary column
                item.SubItems.Add(customer.Name);
                item.SubItems.Add(customer.PhoneNumber);
                item.SubItems.Add(customer.EmailAddress);
                listViewCustomers.Items.Add(item); // Populate the listview
            }
        }

        private void btnAddCustomer_Click_1(object sender, EventArgs e)
        {
            // Open the FormAddCustomer form
            using (var addCustomerForm = new FormAddCustomer())
            {
                if (addCustomerForm.ShowDialog() == DialogResult.OK)
                {
                    // If a customer was added successfully refresh the list
                    LoadCustomersIntoListView();
                }
            }
        }

        private void btnEditCustomer_Click_1(object sender, EventArgs e)
        {
            // If a customer is selected
            if (listViewCustomers.SelectedItems.Count > 0)
            {
                // Get the selected customers customer number
                int selectedIndex = listViewCustomers.SelectedIndices[0];
                Customer selectedCustomer = customerController.GetCustomerByIndex(selectedIndex);

                // Open the EditCusotmer form
                using (var editCustomerForm = new FormEditCustomer(selectedCustomer))
                {
                    if (editCustomerForm.ShowDialog() == DialogResult.OK)
                    {
                        // If a customer was edited successfully refresh the list
                        LoadCustomersIntoListView();
                    }
                }
            }
            else
            {
                // No customer selected
                MessageBox.Show("Please select a customer to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnDeleteCustomer_Click_1(object sender, EventArgs e)
        {
            // If a customer is selected
            if (listViewCustomers.SelectedItems.Count > 0)
            {
                // Get the selected customers' customer number
                var selectedItem = listViewCustomers.SelectedItems[0];
                int customerNumber = int.Parse(selectedItem.Text);

                var confirmation = MessageBox.Show("Are you sure you want to delete this customer?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmation == DialogResult.Yes)
                {
                    customerController.DeleteCustomer(customerNumber);
                    LoadCustomersIntoListView(); // refresh the list
                }
            }
            else
            {
                // No customer selected
                MessageBox.Show("Please select a customer to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            // If a customer is selected
            if (listViewCustomers.SelectedItems.Count > 0)
            {
                // Get the selected customers' customer number
                int selectedCustomerNumber = int.Parse(listViewCustomers.SelectedItems[0].Text);
                Customer selectedCustomer = customerController.FindCustomerByNumber(selectedCustomerNumber);
                if (selectedCustomer != null)
                {
                    // Open the DisplayCustomer form
                    FormDisplayCustomer formDisplay = new FormDisplayCustomer(selectedCustomer);
                    formDisplay.Show();
                }
            }
            else
            {
                // No customer selected
                MessageBox.Show("Please select a customer first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close(); // Close the form
        }

        private void buttonManageAccounts_Click(object sender, EventArgs e)
        {
            // If a customer is selected
            if (listViewCustomers.SelectedItems.Count > 0)
            {
                // Get the selected customers' customer number
                int selectedCustomerNumber = int.Parse(listViewCustomers.SelectedItems[0].Text);
                Customer selectedCustomer = customerController.FindCustomerByNumber(selectedCustomerNumber);
                if (selectedCustomer != null)
                {
                    // Open the DisplayCustomer form
                    FormManageAccounts formDisplay = new FormManageAccounts(selectedCustomer);
                    formDisplay.Show();
                }
            }
            else
            {
                // No customer selected
                MessageBox.Show("Please select a customer first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}