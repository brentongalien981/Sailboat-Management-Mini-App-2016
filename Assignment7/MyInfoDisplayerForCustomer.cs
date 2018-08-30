using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment7
{
    class MyInfoDisplayerForCustomer
    {
        public static void DisplayInfo(Label[] arrayOfCustomerLabelsInfo, Customer selectedCustomer)
        {
            string name = "";
            string address = "";
            string phone = "";

            if (selectedCustomer != null)
            {
                name += selectedCustomer.Name;
                address += selectedCustomer.Address;
                phone += selectedCustomer.TelephoneNumber;
            }

            // TODO: Use constants for indexes.
            // Name
            arrayOfCustomerLabelsInfo[0].Text = "Name: " + name;
            // Address
            arrayOfCustomerLabelsInfo[1].Text = "Address: " + address;
            // Phone
            arrayOfCustomerLabelsInfo[2].Text = "Phone: " + phone;
        }
    }
}
