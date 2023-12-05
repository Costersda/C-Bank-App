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
    public partial class FormAddCustomer : FormBranding
    {
        private bool isStaff;

        // Constructor
        public FormAddCustomer()
        {
            InitializeComponent();
            labelSubTitle.Text = "Add Customer:"; // Set subtitle
        }

        private void Customer_CheckedChanged(object sender, EventArgs e)
        {
            if (Customer.Checked)
            {
                isStaff = false;
            }
        }

        private void Staff_CheckedChanged(object sender, EventArgs e)
        {
            if (Staff.Checked)
            {
                isStaff = true;
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {

            // Check that none of the textboxes are empty
            if (string.IsNullOrWhiteSpace(txtName.Text)
                || string.IsNullOrWhiteSpace(txtPhoneNumber.Text)
                || string.IsNullOrWhiteSpace(txtEmailAddress.Text)
                || (!Customer.Checked && !Staff.Checked))
            {
                MessageBox.Show("All fields must be filled out!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!isStaff)
            {
                // Create a new customer and add it via the controller.
                customerController.AddCustomer(txtName.Text, txtPhoneNumber.Text, txtEmailAddress.Text);
            }
            else
            {
                // Create a new staff customer and add it via the controller.
                customerController.AddStaff(txtName.Text, txtPhoneNumber.Text, txtEmailAddress.Text);
            }


            MessageBox.Show("Customer added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;  // Show that the customer was added.
            this.Close();
        }


        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close(); //Close the form
        }
    }
}
