using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    public class SailBoat : Boat
    {
        // Constants
        private const int NUMBER_OF_SAILS_DEFAULT = 0;
        private const int NUMBER_OF_MASTS_DEFAULT = 0;


        // Fields
        private int numberOfSails;
        private int numberOfMasts;



        // Properties
        public int NumberOfSails
        {
            get
            {
                return numberOfSails;
            }
            set
            {
                numberOfSails = value;
            }
        }

        public int NumberOfMasts
        {
            get
            {
                return numberOfMasts;
            }
            set
            {
                numberOfMasts = value;
            }
        }



        // Constructors
        public SailBoat() : this(NUMBER_OF_SAILS_DEFAULT, NUMBER_OF_MASTS_DEFAULT)
        {

        }

        public SailBoat(int numberOfSails, int numberOfMasts) : this(REGISTRATION_NUMBER_DEFAULT, LENGTH_DEFAULT, MANUFACTURER_DEFAULT, YEAR_DEFAULT, numberOfSails, numberOfMasts)
        {
        }

        public SailBoat(int registrationNumber, int length, string manufacturer,
                 int year, int numberOfSails, int numberOfMasts) : base(registrationNumber, length, manufacturer, year)
        {
            NumberOfSails = numberOfSails;
            NumberOfMasts = numberOfMasts;

            base.MyClassType = "SailBoat";
        }



        // Overriden Methods
        public override string ToString()
        {
            string classInString = base.ToString();
            classInString += "," + NumberOfSails + "," + NumberOfMasts;

            return classInString;
        }
    }
}
