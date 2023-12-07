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
    public partial class FormManageAccounts : FormBranding
    {

        private Customer currentCustomer;

        public FormManageAccounts(Customer selectedCustomer)
        {
            InitializeComponent();
            currentCustomer = selectedCustomer;
            labelSubTitle.Text = "Manage Accounts:"; // Set the subtitle
            LoadAccountIntoListView();
            labelCustomerName.Text = selectedCustomer.Name;
        }

        private void LoadAccountIntoListView()
        {
            listViewAccounts.Items.Clear(); // Clear the existing items
            foreach (var account in currentCustomer.Accounts)
            {
                var item = new ListViewItem(account.AccountNumber.ToString()); // The AccountNumber as the primary column
                item.SubItems.Add(account.GetType().Name);
                item.SubItems.Add(account.Balance.ToString("C"));
                listViewAccounts.Items.Add(item); // Populate the listview
            }
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            // Open the FormAddAccount form
            using (var addAccountForm = new FormAddAccount(currentCustomer))
            {
                if (addAccountForm.ShowDialog() == DialogResult.OK)
                {
                    // If a account was added successfully refresh the list
                    LoadAccountIntoListView();
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close(); //Close the form
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            // If a account is selected
            if (listViewAccounts.SelectedItems.Count > 0)
            {
                // Get the selected account
                int selectedIndex = listViewAccounts.SelectedIndices[0];
                Account selectedAccount = customerController.GetAccountByIndex(currentCustomer, selectedIndex);

               // Account selectedAccount = currentCustomer.Accounts[selectedIndex];

                if (double.TryParse(textBoxDeposit.Text, out double depositAmount))
                {
                    // Perform the deposit
                    //TODO create a CustomerController method that takes the selected customer, selected account and deposit amount as parameters
                    customerController.AccountDeposit(selectedAccount, depositAmount);
                    //selectedAccount.Deposit(depositAmount);
                    LoadAccountIntoListView();
                }
                else
                {
                    // Display an error message for an invalid deposit amount
                    MessageBox.Show("Please enter a valid numeric deposit amount.");
                }

            }
            else
            {
                // No account selected
                MessageBox.Show("Please select an account to deposit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            // If a account is selected
            if (listViewAccounts.SelectedItems.Count > 0)
            {
                // Get the selected account
                int selectedIndex = listViewAccounts.SelectedIndices[0];
                Account selectedAccount = customerController.GetAccountByIndex(currentCustomer, selectedIndex);

                if (double.TryParse(textBoxWithdraw.Text, out double withdrawalAmount))
                {
                    try
                    {
                        // Perform the withdrawal
                        //TODO create a CustomerController method that takes the selected customer, selected account and deposit amount as parameters
                        customerController.AccountWithdraw(selectedAccount, withdrawalAmount);
                       // selectedAccount.Withdraw(withdrawalAmount);
                        LoadAccountIntoListView();
                    }
                    catch (WithdrawalException ex)
                    {
                        // Display the exception message for a failed withdrawal
                        MessageBox.Show(ex.Message, "Withdrawal Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        LoadAccountIntoListView();
                    }
                }
                else
                {
                    // Display an error message for an invalid withdrawal amount
                    MessageBox.Show("Please enter a valid numeric withdrawal amount.");
                }

            }
            else
            {
                // No account selected
                MessageBox.Show("Please select an account to withdraw.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (listViewAccounts.SelectedItems.Count > 0)
            {
                int selectedIndex = listViewAccounts.SelectedIndices[0];
                Account selectedAccount = customerController.GetAccountByIndex(currentCustomer, selectedIndex);


                // Open the FormAddCustomer form
                using (var transferForm = new FormTransfer(currentCustomer, selectedAccount))
                {
                    if (transferForm.ShowDialog() == DialogResult.OK)
                    {
                        // If a transfer was successful refresh the list
                        LoadAccountIntoListView();
                    }
                }
            }
            else
            {
                // No account selected
                MessageBox.Show("Please select an account to transfer.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnCalculateInterest_Click(object sender, EventArgs e)
        {
            if (listViewAccounts.SelectedItems.Count > 0)
            {
                int selectedIndex = listViewAccounts.SelectedIndices[0];
                Account selectedAccount = currentCustomer.Accounts[selectedIndex];                         
                MessageBox.Show(selectedAccount.CalculateInterest());
                LoadAccountIntoListView();

            }
            else
            {
                // No account selected
                MessageBox.Show("Please select an account to calculate interest.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
