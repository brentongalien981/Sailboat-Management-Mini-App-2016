using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    public class Boat
    {
        #region Constants
        protected const int REGISTRATION_NUMBER_DEFAULT = -999999;
        protected const int LENGTH_DEFAULT = -5;
        protected const string MANUFACTURER_DEFAULT = "BoatManufacturer";
        protected const int YEAR_DEFAULT = -1900;
        public const int NUMBER_OF_FIELDS = 5;

        public const int FIELD_BOAT_TYPE_INDEX = 0;
        public const int FIELD_REG_NUM_INDEX = 1;
        public const int FIELD_LENGTH_INDEX = 2;
        public const int FIELD_MANUFACTURER_INDEX = 3;
        public const int FIELD_YEAR_INDEX = 4;
        #endregion



        #region Fields
        private int registrationNumber;
        private readonly int length;
        private readonly string manufacturer;
        private readonly int year;
        private Customer owner;
        #endregion



        #region Properties
        public int RegistrationNumber
        {
            get
            {
                return registrationNumber;
            }
            set
            {
                registrationNumber = value;
            }
        }

        public int Length
        {
            get
            {
                return length;
            }
        }

        public string Manufacturer
        {
            get
            {
                return manufacturer;
            }
        }

        public int Year
        {
            get
            {
                return year;
            }
        }

        public Customer Owner
        {
            get
            {
                return owner;
            }
            set
            {
                if (owner == null) // Make sure that the boat is only assigned once to a customer.
                {
                    owner = value;
                    //value.UpdateBoatsArr(this);
                }

            }
        }

        // My own helper property
        public string MyClassType { get; set; }
        #endregion


        #region Constructors
        public Boat() : this(REGISTRATION_NUMBER_DEFAULT, LENGTH_DEFAULT, MANUFACTURER_DEFAULT, YEAR_DEFAULT, null)
        {
        }

        public Boat(int registrationNumber) : this(registrationNumber, LENGTH_DEFAULT, MANUFACTURER_DEFAULT, YEAR_DEFAULT, null)
        {
        }

        public Boat(int registrationNumber, int length, string manufacturer, int year) : this(registrationNumber, length, manufacturer, year, null)
        {
        }

        public Boat(int registrationNumber, int length, string manufacturer, int year, Customer owner)
        {
            this.registrationNumber = registrationNumber;
            this.length = length;
            this.manufacturer = manufacturer;
            this.year = year;
            this.owner = owner;

            MyClassType = "Boat";
        }
        #endregion


        public bool AssignBoatToSlip(Slip slip)
        {
            if (slip == null ||
                slip.MyBoat != null ||
                slip.Length < Length)
            {
                return false;
            }

            // Kind of like the else...
            slip.MyBoat = this;
            return true;
        }



        public void RemoveBoatFromSlip(Slip slip)
        {
            slip.MyBoat = null;
        }



        public string GetInfo()
        {
            string info = "Boat Info:\n";

            info += "RegistrationNumber: " + RegistrationNumber + "\n";
            info += "Length: " + Length + "\n";
            info += "Manufacturer: " + Manufacturer + "\n";
            info += "Year: " + Year + "\n";
            info += "Owner: " + Owner;

            return info;
        }



        // Overridden Methods
        public override string ToString()
        {
            string classInString = MyClassType + "," + RegistrationNumber + "," + Length + "," + Manufacturer + "," + Year + ",";

            // This is to avoid NULL EXCEPTION if Owner isn't referenced to an object yet.
            if (Owner == null)
            {
                classInString += "NoOwnerAssigned";
            }
            else
            {
                classInString += Owner.Name;
            }

            return classInString;
        }

        public override bool Equals(object obj)
        {
            bool isEqual = true;

            if (this.GetType() != obj.GetType())
            {
                isEqual = false;
            }
            else
            {
                Boat tempBoat = (Boat)obj;
                if (RegistrationNumber == tempBoat.RegistrationNumber)
                {
                    isEqual = true;
                }
                else
                {
                    isEqual = false;
                }
            }

            return isEqual;
        }
        #region
        #endregion
    }
}
