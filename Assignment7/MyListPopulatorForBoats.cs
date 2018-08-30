using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment7
{
    class MyListPopulatorForBoats
    {
        public static void List(ListBox listBox_boats, Boat[] arrayOfBoats)
        {
            // Refresh listbox.
            listBox_boats.Items.Clear();

            int counter = 0;
            string shortBoatInfo;

            while (arrayOfBoats[counter] != null)
            {
                shortBoatInfo = arrayOfBoats[counter].RegistrationNumber + ", " + arrayOfBoats[counter].MyClassType;
                listBox_boats.Items.Add(shortBoatInfo);
                ++counter;

            }
        }
    }
}
