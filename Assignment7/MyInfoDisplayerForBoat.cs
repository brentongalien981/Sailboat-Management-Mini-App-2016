using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment7
{
    class MyInfoDisplayerForBoat
    {
        public static void DisplayInfo(Label[] arrayOfBoatLabelsInfo, Boat selectedBoat)
        {
            string regNum = "";
            string myClassType = "";
            string length = "";
            string manufacturer = "";
            string year = "";

            if (selectedBoat != null)
            {
                regNum += selectedBoat.RegistrationNumber;
                myClassType += selectedBoat.MyClassType;
                length += selectedBoat.Length;
                manufacturer += selectedBoat.Manufacturer;
                year += selectedBoat.Year;
            }

            arrayOfBoatLabelsInfo[Boat.FIELD_REG_NUM_INDEX].Text = "Registration No: " + regNum;
            arrayOfBoatLabelsInfo[Boat.FIELD_BOAT_TYPE_INDEX].Text = "Type: " + myClassType;
            arrayOfBoatLabelsInfo[Boat.FIELD_LENGTH_INDEX].Text = "Length: " + length;
            arrayOfBoatLabelsInfo[Boat.FIELD_MANUFACTURER_INDEX].Text = "Manufacturer: " + manufacturer;
            arrayOfBoatLabelsInfo[Boat.FIELD_YEAR_INDEX].Text = "Year: " + year;
        }
    }
}
