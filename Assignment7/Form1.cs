using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment7
{
    public partial class Form1 : Form
    {
        private MyProgramController myProgramController;

        public Form1()
        {
            InitializeComponent();

            //
            myProgramController = new MyProgramController();
        }

        private void button_customerLoad_Click(object sender, EventArgs e)
        {
            // TODO: Don't forget.
            // Load the file "Customer.txt".
            //string filePath = this.textBox_customerFilePath.Text;
            string filePath = "Customers.txt";

            // Set the dataStorer for customers.
            myProgramController.LoadCustomer(filePath);

            //
            myProgramController.LoadRelationships();

            // Populate the customer's listBox.
            myProgramController.PopulateCustomerList(this.listBox_customers);

            // Update the groupBox->listBox to show the boats owned.
            this.listBox_customers_SelectedIndexChanged(null, null);
            //myProgramController.DisplayCustomerInfo(null, -1, listBox_ownedBoats);
        }

        private void button_boatLoad_Click(object sender, EventArgs e)
        {
            // TODO: 
            // Load the file "Boats.txt".
            //string filePath = this.textBox_boatFilePath.Text;
            string filePath = "Boats.txt";

            // Set the dataStorer for boats.
            myProgramController.LoadBoat(filePath);

            //
            myProgramController.LoadRelationships();

            // Populate the boat's listBox.
            myProgramController.PopulateBoatList(this.listBox_boats);

            //
            this.listBox_boats_SelectedIndexChanged(null, null);
        }

        private void listBox_customers_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Find the clicked index.
            int indexOfSelectedCustomer = listBox_customers.SelectedIndex;

            // Update the labels for customer info.
            Label[] arrayOfCustomerLabelsInfo = new Label[Customer.NUMBER_OF_FIELDS];
            arrayOfCustomerLabelsInfo[Customer.FIELD_NAME_INDEX] = this.label_customerName;
            arrayOfCustomerLabelsInfo[Customer.FIELD_ADDRESS_INDEX] = this.label_customerAddress;
            arrayOfCustomerLabelsInfo[Customer.FIELD_TELNUM_INDEX] = this.label_customerPhone;

            myProgramController.DisplayCustomerInfo(arrayOfCustomerLabelsInfo, indexOfSelectedCustomer, listBox_ownedBoats);


        }

        private void listBox_boats_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Find the clicked index.
            int indexOfSelectedBoat = listBox_boats.SelectedIndex;

            // Update the labels for customer info.
            Label[] arrayOfBoatLabelsInfo = new Label[Boat.NUMBER_OF_FIELDS];
            arrayOfBoatLabelsInfo[Boat.FIELD_REG_NUM_INDEX] = this.label_boatRegNum;
            arrayOfBoatLabelsInfo[Boat.FIELD_BOAT_TYPE_INDEX] = this.label_boatType;
            arrayOfBoatLabelsInfo[Boat.FIELD_LENGTH_INDEX] = this.label_boatLength;
            arrayOfBoatLabelsInfo[Boat.FIELD_MANUFACTURER_INDEX] = this.label_boatManufacturer;
            arrayOfBoatLabelsInfo[Boat.FIELD_YEAR_INDEX] = this.label_boatYear;

            myProgramController.DisplayBoatInfo(arrayOfBoatLabelsInfo, indexOfSelectedBoat);
        }



        private void button_assignBoat_Click(object sender, EventArgs e)
        {
            // Find the clicked index from customers list.
            int indexOfSelectedCustomer = listBox_customers.SelectedIndex;

            // Find the clicked index from boats list.
            int indexOfSelectedBoat = listBox_boats.SelectedIndex;

            // Make sure a boat and a customer are selected.
            if (indexOfSelectedCustomer != -1 &&
                indexOfSelectedBoat != -1)
            {
                myProgramController.AssignBoat(indexOfSelectedCustomer, indexOfSelectedBoat, this.listBox_ownedBoats);
            }
        }

        private void button_boatSave_Click(object sender, EventArgs e)
        {
            myProgramController.SaveOwnershipRelationship();
        }
    }
}
