﻿using System;
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
    public partial class FormAddAccount : FormBranding
    {
        private Customer currentCustomer;
        private Account everydayAccount;
        private Account investmentAccount;
        private Account omniAccount;
        private bool isStaff;

        public FormAddAccount(Customer selectedCustomer)
        {
            InitializeComponent();
            currentCustomer = selectedCustomer;
            labelSubTitle.Text = "Add an Account:"; // Set the subtitle
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close(); //Close the form
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Everyday.Checked)
            {
                everydayAccount = new Everyday(0);
                currentCustomer.AddAccount(everydayAccount);
                
                MessageBox.Show("Account added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;  // Show that the account was added.
                this.Close();
            }
            else if (Investment.Checked)
            {
                if (currentCustomer.GetType().Name == "Staff")
                {
                    isStaff = true;
                }
                else
                {
                    isStaff = false;
                }
                investmentAccount = new Investment(0, 10, 0.04, isStaff);
                currentCustomer.AddAccount(investmentAccount);
                
                MessageBox.Show("Account added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;  // Show that the account was added.
                this.Close();
            }
            else if (Omni.Checked)
            {
                if (currentCustomer.GetType().Name == "Staff")
                {
                    isStaff = true;
                }
                else
                {
                    isStaff = false;
                }
                omniAccount = new Omni(0, 10, 0.04, 500, isStaff);
                currentCustomer.AddAccount(omniAccount);

                MessageBox.Show("Account added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;  // Show that the account was added.
                this.Close();
            }
            else
            {
                // Display an error message for no selected account
                MessageBox.Show("Please select an account type.");
            }
        }
    }
}