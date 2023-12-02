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
    public partial class FormDisplayCustomer : FormBranding
    {
        private Customer displayedCustomer;

        // Constructor
        public FormDisplayCustomer(Customer selectedCustomer)
        {
            InitializeComponent();
            displayedCustomer = selectedCustomer;
            labelSubTitle.Text = "Selected Customer:"; // Set subtitle
        }

        // Display the customer information
        private void FormDisplayCustomer_Load_1(object sender, EventArgs e)
        {
            txtName.Text = displayedCustomer.Name;
            txtPhoneNumber.Text = displayedCustomer.PhoneNumber;
            txtEmailAddress.Text = displayedCustomer.EmailAddress;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the form
        }

    }
}
