using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment7
{
    class MyListPopulatorForCustomers
    {
        public static void List(ListBox listBox_customers, Customer[] arrayOfCustomers)
        {
            // Refresh.
            listBox_customers.Items.Clear();

            int counter = 0;
            string shortCustomerInfo;

            while (arrayOfCustomers[counter] != null)
            {
                shortCustomerInfo = arrayOfCustomers[counter].Name + ", " + arrayOfCustomers[counter].TelephoneNumber;
                listBox_customers.Items.Add(shortCustomerInfo);
                ++counter;
            }
            
        }
    }
}
