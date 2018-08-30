using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment7
{
    class MyListPopulatorForOwnedBoats
    {
        public static void List(ListBox listBox_ownedBoats, Customer customer)
        {
            // Refresh listbox.
            listBox_ownedBoats.Items.Clear();

            int counter = 0;
            string shortBoatInfo;

            while ((customer != null) &&
                   (customer.BoatsArr != null) &&
                   (counter < customer.BoatsArr.Length))
            {
                shortBoatInfo = customer.BoatsArr[counter].RegistrationNumber + ", " + customer.BoatsArr[counter].MyClassType;
                //shortBoatInfo = arrayOfBoats[counter].RegistrationNumber + ", " + arrayOfBoats[counter].MyClassType;
                listBox_ownedBoats.Items.Add(shortBoatInfo);
                ++counter;

            }
        }
    }
}
