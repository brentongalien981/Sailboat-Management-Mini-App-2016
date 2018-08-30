using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment7
{
    class MyProgramController
    {
        #region Fields
        private MyDataStorerForCustomers myDataStorerForCustomers;
        private MyDataStorerForBoats myDataStorerForBoats;
        private MyDataStorerForOwnedBoats myDataStorerForOwnedBoats;
        #endregion


        public MyProgramController()
        {
            myDataStorerForCustomers = null;
            myDataStorerForBoats = null;
            myDataStorerForOwnedBoats = new MyDataStorerForOwnedBoats();
        }

        public void LoadRelationships()
        {
            if (myDataStorerForOwnedBoats.NumOfOwnership > 0)
            {
               
                // These are the default filePaths for Boats and Customers data storers.
                string defaultCustomerFilePath = "Customers.txt";
                string defaultBoatFilePath = "Boats.txt";

                // Make sure the program is using the default data storers.
                LoadCustomer(defaultCustomerFilePath);
                LoadBoat(defaultBoatFilePath);
                

                // This is to provide the saved ownership previously made.
                for (int i = 0; i < myDataStorerForOwnedBoats.NumOfOwnership; i++)
                {
                    string thePhoneNum = myDataStorerForOwnedBoats.ArrayOfPhoneAndRegNumPair[i, 0];
                    string theRegNum = myDataStorerForOwnedBoats.ArrayOfPhoneAndRegNumPair[i, 1];

                    Customer theCustomer = null;
                    foreach (Customer customer in myDataStorerForCustomers.ArrayOfCustomers)
                    {
                        if (customer.TelephoneNumber == thePhoneNum)
                        {
                            theCustomer = customer;
                            break;
                        }
                    }

                    Boat theBoat = null;
                    foreach (Boat boat in myDataStorerForBoats.ArrayOfBoats)
                    {
                        if (boat.RegistrationNumber.ToString() == theRegNum)
                        {
                            theBoat = boat;
                            break;
                        }
                    }

                    // Assign ownership.
                    if (theCustomer != null &&
                        theBoat != null)
                    {
                        theCustomer.UpdateBoatsArr(theBoat);
                        theBoat.Owner = theCustomer;
                    }

                }
            }
           
        }

        public void LoadCustomer(string filePath)
        {
            myDataStorerForCustomers = new MyDataStorerForCustomers(filePath);
        }

        public void LoadBoat(string filePath)
        {
            myDataStorerForBoats = new MyDataStorerForBoats(filePath);
        }

        public void PopulateCustomerList(ListBox listBox_customers)
        {
            MyListPopulatorForCustomers.List(listBox_customers, myDataStorerForCustomers.ArrayOfCustomers);
        }

        public void PopulateBoatList(ListBox listBox_boats)
        {
            MyListPopulatorForBoats.List(listBox_boats, myDataStorerForBoats.ArrayOfBoats);
        }

        public void DisplayCustomerInfo(Label[] arrayOfCustomerLabelsInfo, int indexOfSelectedCustomer, ListBox listBox_ownedBoats)
        {
            Customer selectedCustomer = null;

            if (indexOfSelectedCustomer != -1)
            {
                selectedCustomer = myDataStorerForCustomers.ArrayOfCustomers[indexOfSelectedCustomer];
            }

            MyInfoDisplayerForCustomer.DisplayInfo(arrayOfCustomerLabelsInfo, selectedCustomer);

            // Update the groupBox->listBox to show the boats owned.
            MyListPopulatorForOwnedBoats.List(listBox_ownedBoats, selectedCustomer);
        }

        public void AssignBoat(int indexOfSelectedCustomer, int indexOfSelectedBoat, ListBox listBox_ownedBoats)
        {
            // Selected customer.
            Customer selectedCustomer = myDataStorerForCustomers.ArrayOfCustomers[indexOfSelectedCustomer];
            // Selected boat.
            Boat selectedBoat = myDataStorerForBoats.ArrayOfBoats[indexOfSelectedBoat];

            // Make sure the boat doesn't have an owner yet.
            if (selectedBoat.Owner == null)
            {
                // Add the ownership to data storer.
                string customerPhoneNum = selectedCustomer.TelephoneNumber;
                string boatRegNum = selectedBoat.RegistrationNumber.ToString();

                myDataStorerForOwnedBoats.AssignBoatToOwner(customerPhoneNum, boatRegNum);

                // Update ownership for:
                // customer and..
                selectedCustomer.UpdateBoatsArr(selectedBoat);
                // boat.
                selectedBoat.Owner = selectedCustomer;

                // Update the ListBox for boats owned.
                MyListPopulatorForOwnedBoats.List(listBox_ownedBoats, selectedCustomer);
            }
            else { MyDebugger.ShowComment("already has an owner"); }
        }

        public void DisplayBoatInfo(Label[] arrayOfBoatLabelsInfo, int indexOfSelectedBoat)
        {
            Boat selectedBoat = null;

            if (indexOfSelectedBoat != -1)
            {
                selectedBoat = myDataStorerForBoats.ArrayOfBoats[indexOfSelectedBoat];
            }
                        
            MyInfoDisplayerForBoat.DisplayInfo(arrayOfBoatLabelsInfo, selectedBoat);
        }

        public void SaveOwnershipRelationship()
        {
            myDataStorerForOwnedBoats.Save();
        }
    }
}
