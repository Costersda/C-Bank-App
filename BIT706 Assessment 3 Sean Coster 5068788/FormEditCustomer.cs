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
    public partial class FormEditCustomer : FormBranding
    {

        private Customer currentCustomer;

        // Constructor
        public FormEditCustomer(Customer selectedCustomer)
        {
            InitializeComponent();
            currentCustomer = selectedCustomer;
            labelSubTitle.Text = "Edit Customer:"; // Set the subtitle
        }

        private void FormEditCustomer_Load_1(object sender, EventArgs e)
        {
            // Populate the form fields with the selected customer's data
            txtName.Text = currentCustomer.Name;
            txtPhoneNumber.Text = currentCustomer.PhoneNumber;
            txtEmailAddress.Text = currentCustomer.EmailAddress;
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {

            // Check that none of the textboxes are empty
            if (string.IsNullOrWhiteSpace(txtName.Text)
                || string.IsNullOrWhiteSpace(txtPhoneNumber.Text)
                || string.IsNullOrWhiteSpace(txtEmailAddress.Text))
            {
                MessageBox.Show("All fields must be filled out!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Edit the customers details with the inputed data
            customerController.EditCustomer(currentCustomer.CustomerNumber, txtName.Text, txtPhoneNumber.Text, txtEmailAddress.Text);

            MessageBox.Show("Customer details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;  // Show that the edit was successful.
            this.Close();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close(); // Close the form
        }


    }
}
