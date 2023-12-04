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
    public partial class FormAccounts : FormBranding
    {

        private Account everydayAccount;
        private Account investmentAccount;
        private Account omniAccount;
        private Account selectedAccount;

        public FormAccounts()
        {
            InitializeComponent();

            labelSubTitle.Text = "Accounts:"; // Set subtitle

            // Create instances of the account types
            // Everyday account with initial balance $1000
            everydayAccount = new Everyday(1000);

            // Investment account with initial balance $5000, $7 failed transaction fee, 5% interest rate and not a staff member
            investmentAccount = new Investment(5000, 7, 0.05, false);

            // Omni account with initial balance $2000, $10 failed transaction fee, 3% interest rate, $500 overdraft limit and is a staff member
            omniAccount = new Omni(2000, 10, 0.03, 500, true); 
        }

        private void Everyday_CheckedChanged(object sender, EventArgs e)
        {
            if (Everyday.Checked)
            {
                selectedAccount = everydayAccount;
            }
        }

        private void Investment_CheckedChanged(object sender, EventArgs e)
        {
            if (Investment.Checked)
            {
                selectedAccount = investmentAccount;
            }
        }

        private void Omni_CheckedChanged(object sender, EventArgs e)
        {
            if (Omni.Checked)
            {
                selectedAccount = omniAccount;
            }
        }

        private void buttonDeposit_Click(object sender, EventArgs e)
        {
            {
                if (selectedAccount != null)
                {
                    if (double.TryParse(textBoxDeposit.Text, out double depositAmount))
                    {
                        // Perform the deposit
                        listBoxOutput.Items.Add(selectedAccount.Deposit(depositAmount));

                    }
                    else
                    {
                        // Display an error message for an invalid deposit amount
                        MessageBox.Show("Please enter a valid numeric deposit amount.");
                    }
                }
                else
                {
                    // Display an error message for no selected account
                    MessageBox.Show("Please select an account type.");
                }
            }
        }

        private void buttonWithdraw_Click(object sender, EventArgs e)
        {
            if (selectedAccount != null)
            {
                if (double.TryParse(textBoxWithdraw.Text, out double withdrawalAmount))
                {
                    try
                    {
                        // Perform the withdrawal
                        listBoxOutput.Items.Add(selectedAccount.Withdraw(withdrawalAmount));
                    }
                    catch (WithdrawalException ex)
                    {
                        // Display the exception message for a failed withdrawal
                        MessageBox.Show(ex.Message, "Withdrawal Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                // Display an error message for no selected account
                MessageBox.Show("Please select an account type.");
            }
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            if (selectedAccount != null)
            {
                // Check if the selected account type supports interest calculations (Investment or Omni)
                if (selectedAccount is Investment || selectedAccount is Omni)
                {
                    // Calculate interest based on the account type
                    if (selectedAccount is Investment)
                    {
                        listBoxOutput.Items.Add(((Investment)selectedAccount).CalculateInterest());
                    }
                    else if (selectedAccount is Omni)
                    {
                        listBoxOutput.Items.Add(((Omni)selectedAccount).CalculateInterest());
                    }

                }
                else
                {
                    // Display an error message for account types that do not support interest calculations
                    MessageBox.Show("Interest calculation is not supported for this account type.");
                }
            }
            else
            {
                // Display an error message for no selected account
                MessageBox.Show("Please select an account type.");
            }
        }

        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            if (selectedAccount != null)
            {
                // Get the account details as a string
                string accountDetails = selectedAccount.DisplayInfo();
                MessageBox.Show(accountDetails, "Account Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Display an error message for no selected account
                MessageBox.Show("Please select an account type.");
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close(); // Close the form
        }
    }
}
