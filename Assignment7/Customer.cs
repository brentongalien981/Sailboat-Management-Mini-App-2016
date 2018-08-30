using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    public class Customer
    {
        #region Constants
        //private const string NAME_DEFAULT = "CustomerName";
        //private const string ADDRESS_DEFAULT = "CustomerAddress";
        //private const string TELEPHONE_NUMBER_DEFAULT = "XXXXXXXXXXX";
        public const int NUMBER_OF_FIELDS = 3;

        public const int FIELD_NAME_INDEX = 0;
        public const int FIELD_ADDRESS_INDEX = 1;
        public const int FIELD_TELNUM_INDEX = 2;
        #endregion



        #region Fields
        private string name;
        private string address;
        private string telephoneNumber;

        private Boat[] boatsArr;
        private Slip[] slipsArr;
        #endregion



        #region Properties
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

        public string TelephoneNumber
        {
            get
            {
                return telephoneNumber;
            }
            set
            {
                telephoneNumber = value;
            }
        }

        public Boat[] BoatsArr
        {
            get
            {
                return boatsArr;
            }
            set
            {
                boatsArr = value;
            }
        }

        public Slip[] SlipsArr
        {
            get
            {
                return slipsArr;
            }
            set
            {
                slipsArr = value;
            }
        }

        // My own helper property
        public string MyClassType { get; set; }
        #endregion



        #region Constructors
        //public Customer() : this(NAME_DEFAULT, ADDRESS_DEFAULT, TELEPHONE_NUMBER_DEFAULT)
        //{
        //}

        //public Customer(string name) : this(name, ADDRESS_DEFAULT, TELEPHONE_NUMBER_DEFAULT)
        //{
        //}

        public Customer(string name, string address, string telephoneNumber)
        {
            this.name = name;
            this.address = address;
            this.telephoneNumber = telephoneNumber;
            this.boatsArr = null;
            this.slipsArr = null;

            MyClassType = "Customers";
        }
        #endregion
        


        public string GetInfo()
        {
            string info = "Customer Info:\n";

            info += "Name: " + Name + "\n";
            info += "Address: " + Address + "\n";
            info += "TelephoneNumber: " + TelephoneNumber + "\n";
            info += "BoatsArr: " + BoatsArr + "\n";
            info += "SlipsArr: " + SlipsArr;

            return info;
        }




        // Helper Methods

        // In essence, this method adds the argument slip to the slipsArr.
        public void UpdateSlipsArr(Slip slip)
        {
            if (slipsArr != null)
            {
                // Create an array that is 1 more than the old array.
                Slip[] tempSlipsArr = new Slip[slipsArr.Length + 1];

                // Make the references of the temporary array equal to the actual array.
                for (int i = 0; i < slipsArr.Length; i++)
                {
                    tempSlipsArr[i] = slipsArr[i];
                }

                // Make the last new additional slip refer to the argument passed.
                tempSlipsArr[slipsArr.Length] = slip;

                // 
                slipsArr = tempSlipsArr;
            }
            else
            {
                slipsArr = new Slip[1];
                slipsArr[0] = slip;
            }
        }


        public void UpdateBoatsArr(Boat boat)
        {
            if (boatsArr != null) 
            {
                Boat[] tempBoatsArr = new Boat[boatsArr.Length + 1]; // Create a temporary Boat[] with 1 more spot for the boat arg to be added to.

                for (int i = 0; i < boatsArr.Length; i++)
                {
                    tempBoatsArr[i] = boatsArr[i]; // Copy the arrays.
                }

                tempBoatsArr[boatsArr.Length] = boat; // Assign the boat arg to the last index.

                boatsArr = tempBoatsArr; // This is now the updated boatsArr.
            }
            else
            {
                boatsArr = new Boat[1];
                boatsArr[0] = boat; // This is basically adding the very first boat object to the boatsArr.
            }    
        }


        public override string ToString()
        {
            string classInString = "[" + MyClassType + "] [" + Name + "] [" + Address + "] [" + TelephoneNumber + "]";
            return classInString;
        }
        #region
        #endregion
    }
}
