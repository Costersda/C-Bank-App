using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace BIT706_Assessment_3_Sean_Coster_5068788
{
    // Creates an Application Data object of the properties to be saved and loaded
    [Serializable]
    public class ApplicationData
    {
        public List<Customer> Customers { get; set; }
        public int LastAccountNumber { get; set; }
        public int LastCustomerNumber { get; set; }
    }


}
