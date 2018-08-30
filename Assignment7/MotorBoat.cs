using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7

{
    public class MotorBoat : Boat
    {
        // Constants
        private const string FUEL_TYPE_DEFAULT = "gasoline";
        private const int NUMBER_OF_ENGINES_DEFAULT = 1;

        // Fields
        private string fuelType;
        private int numberOfEngines;


        // Properties
        public int NumberOfEngines
        {
            get
            {
                return numberOfEngines;
            }
            set
            {
                numberOfEngines = value;
            }
        }
        public string FuelType
        {
            get
            {
                return fuelType;
            }
            set
            {
                if (value == "gasoline" || value == "diesel")
                {
                    fuelType = value;
                }
            }
        }



        // Constructors
        public MotorBoat() : this(NUMBER_OF_ENGINES_DEFAULT, FUEL_TYPE_DEFAULT)
        {
        }

        public MotorBoat(int numberOfEngines, string fuelType) : this(REGISTRATION_NUMBER_DEFAULT, LENGTH_DEFAULT, MANUFACTURER_DEFAULT, YEAR_DEFAULT, numberOfEngines, fuelType)
        {
        }

        public MotorBoat(int registrationNumber, int length, string manufacturer,
                         int year, int numberOfEngines, string fuelType) : base(registrationNumber, length, manufacturer, year)
        {
            NumberOfEngines = numberOfEngines;
            FuelType = fuelType;

            base.MyClassType = "MotorBoat";
        }


        // Overridden Methods
        public override string ToString()
        {
            string classInString = base.ToString();
            classInString += "," + NumberOfEngines + "," + FuelType;
            return classInString;
        }
    }
}
