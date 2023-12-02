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
    public partial class FormBranding : Form
    {

        // Static controller variable
        protected static CustomerController customerController = new CustomerController();

        public FormBranding()
        {
            InitializeComponent();
        }
    }
}
