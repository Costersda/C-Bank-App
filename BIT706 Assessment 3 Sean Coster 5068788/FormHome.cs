using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIT706_Assessment_2_Sean_Coster_5068788
{
    public partial class FormHome : FormBranding
    {
        public FormHome()
        {
            InitializeComponent();
            labelSubTitle.Text = "Main Menu:";
        }

        private void btnManageCustomers_Click(object sender, EventArgs e)
        {
            FormManageCustomers manageCustomersForm = new FormManageCustomers();

            // Show the FormManageCustomers form
            manageCustomersForm.Show();
        }

        private void btnManageAccounts_Click(object sender, EventArgs e)
        {
            FormAccounts manageAccountsForm = new FormAccounts();
            // Show the FormAccounts form
            manageAccountsForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close(); // Close the program
        }


    }
}
