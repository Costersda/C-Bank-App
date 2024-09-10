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
    public partial class FormTransfer : FormBranding
    {
        private Customer currentCustomer;
        private Account currentAccount;

        public FormTransfer(Customer selectedCustomer, Account selectedAccount)
        {
            InitializeComponent();
            labelSubTitle.Text = "Transfer:"; // Set the subtitle
            currentCustomer = selectedCustomer;
            currentAccount = selectedAccount;
            LoadAccountIntoListView();
            CurrentAccountLabels();

            
        }

        private void LoadAccountIntoListView()
        {
            listViewAccounts.Items.Clear(); // Clear the existing items
            foreach (var account in currentCustomer.Accounts)
            {
                var item = new ListViewItem(account.AccountNumber.ToString()); // The AccountNumber as the primary column
                item.SubItems.Add(account.GetType().Name);
                item.SubItems.Add(account.Balance.ToString());
                listViewAccounts.Items.Add(item); // Populate the listview


            }
        }

        // Sets the current account on the forms labels
        private void CurrentAccountLabels()
        {
            labelAccountNumber.Text = "Account#: " + currentAccount.AccountNumber;
            labelAccountType.Text = "Account Type: " + currentAccount.GetType().Name;
            labelAccountBalance.Text = "Account Balance: $" + currentAccount.Balance;
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close(); //Close the form
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            // If a account is selected
            if (listViewAccounts.SelectedItems.Count > 0)
            {
                // Get the selected account
                int selectedIndex = listViewAccounts.SelectedIndices[0];
                Account selectedAccount = currentCustomer.Accounts[selectedIndex];

                if (!customerController.AccountTransferCheck(selectedAccount, currentAccount))
                {
                    // Same account selected
                    MessageBox.Show("Please select a different account to transfer.", "Warning, Same account selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (double.TryParse(textBoxTransfer.Text, out double transferAmount))
                    {
                        try
                        {
                            // Perform the transfer
                            customerController.AccountTransfer(currentAccount, selectedAccount, transferAmount);
                            LoadAccountIntoListView();
                            MessageBox.Show("Transfer successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;  // Show that the transfer was successful.
                            this.Close();

                        }
                        catch (WithdrawalException ex)
                        {
                            // Display the exception message for a failed transfer
                            MessageBox.Show(ex.Message, "Transfer Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            CurrentAccountLabels();
                        }
                    }
                    else
                    {
                        // Display an error message for an invalid transfer amount
                        MessageBox.Show("Please enter a valid numeric transfer amount.");
                    }
                }

            }
            else
            {
                // No account selected
                MessageBox.Show("Please select an account to transfer.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
