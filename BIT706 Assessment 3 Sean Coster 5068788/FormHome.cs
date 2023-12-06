using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIT706_Assessment_3_Sean_Coster_5068788
{
    public partial class FormHome : FormBranding
    {
               

        public FormHome()
        {
            InitializeComponent();
            labelSubTitle.Text = "Main Menu:";
            ApplicationData deserializedData = DeserializeData(@"Data\appdata.bin");
            if (deserializedData.Customers != null)
            {
                customerController.Customers = deserializedData.Customers;
                Account.LastAccountNumber = deserializedData.LastAccountNumber;
                Customer.LastCustomerNumber = deserializedData.LastCustomerNumber;
            }
            
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

            ApplicationData dataToSerialize = new ApplicationData
            {
                Customers = customerController.Customers, 
                LastAccountNumber = Account.LastAccountNumber, 
                LastCustomerNumber = Customer.LastCustomerNumber 
            };
            SerializeData(@"Data\appdata.bin", dataToSerialize);

            this.DialogResult = DialogResult.Cancel;
            this.Close(); // Close the program
        }


        private void SerializeData(string relativeFilePath, ApplicationData data)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativeFilePath);
            string directoryPath = Path.GetDirectoryName(filePath);

            // Check if the directory exists; if not, create it.
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            try
            {
                using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fileStream, data);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error during serialization: " + ex.Message);
            }
        }

        private ApplicationData DeserializeData(string relativeFilePath)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativeFilePath);
            ApplicationData data = new ApplicationData();
            if (File.Exists(filePath))
            {
                try
                {
                    using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        data = (ApplicationData)formatter.Deserialize(fileStream);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error during deserialization: " + ex.Message);
                }
            }
            return data;
        }
    }
}
