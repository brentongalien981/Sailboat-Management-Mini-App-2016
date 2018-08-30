using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7

{
    public class Slip
    {
        #region Constants
        private const int SLIP_ID_DEFAULT = 888888;
        private const int WIDTH_DEFAULT = 3;
        private const int LENGTH_DEFAULT = 5;
        private const int DEPTH_DEFAULT = 2;
        #endregion



        #region Fields
        private int slipId;
        private readonly int width;
        private readonly int length;
        private readonly int depth;
        private Customer myCustomer;
        private Boat myBoat;
        #endregion



        #region Properties
        public int SlipId
        {
            get
            {
                return slipId;
            }
            set
            {
                slipId = value;
            }
        }

        public int Width
        {
            get
            {
                return width;
            }
        }

        public int Length
        {
            get
            {
                return length;
            }
        }

        public int Depth
        {
            get
            {
                return depth;
            }
        }

        public Customer MyCustomer
        {
            get
            {
                return myCustomer;
            }
            set
            {
                myCustomer = value;
            }
        }

        public Boat MyBoat
        {
            get
            {
                return myBoat;
            }
            set
            {
                myBoat = value;
            }
        }

        // My own helper property
        public string MyClassType { get; set; }
        #endregion


        #region Constructors
        public Slip() : this(SLIP_ID_DEFAULT, WIDTH_DEFAULT, LENGTH_DEFAULT, DEPTH_DEFAULT)
        {
        }

        public Slip(int slipId) : this(slipId, WIDTH_DEFAULT, LENGTH_DEFAULT, DEPTH_DEFAULT)
        {
        }

        public Slip(int slipId, int width, int length, int depth)
        {
            this.slipId = slipId;
            this.width = width;
            this.length = length;
            this.depth = depth;
            this.myCustomer = null;
            this.myBoat = null;

            MyClassType = "Slip";
        }
        #endregion



        public bool LeaseSlip(Customer myCustomer)
        {
            if (myCustomer == null ||        
                this.myCustomer != null)      // meaning this slip already is assigned to a customer
            {
                return false;
            }

            // Kind of like the else...
            MyCustomer = myCustomer;
            myCustomer.UpdateSlipsArr(this);
            return true;
        }



        public string GetInfo()
        {
            string info = "Slip Info:\n";

            info += "SlipId: " + SlipId + "\n";
            info += "Width: " + Width + "\n";
            info += "Length: " + Length + "\n";
            info += "Depth: " + Depth + "\n";
            info += "Customer: " + MyCustomer + "\n";
            info += "Boat: " + MyBoat;

            return info;
        }


        // Overrideen Methods
        public override string ToString()
        {
            string classInString = "[" + MyClassType + "] [" + SlipId + "] [" + Width + "] [" + Length + "] [" + Depth + "] [";

            // This is to avoid NULL EXCEPTION if MyCustomer isn't referenced to an object yet.
            if (MyCustomer == null)
            {
                classInString += "NoCustomerAssigned] [";
            }
            else
            {
                classInString += MyCustomer.Name + "] [";
            }

            // This is to avoid NULL EXCEPTION if MyBoat isn't referenced to an object yet.
            if (MyBoat == null)
            {
                classInString += "NoBoatAssigned]";
            }
            else
            {
                classInString += MyBoat.RegistrationNumber + "]";
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
                Slip tempSlip = (Slip)obj;
                if (SlipId == tempSlip.SlipId)
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
