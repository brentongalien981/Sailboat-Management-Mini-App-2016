using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    class MyDataStorerForBoats
    {
        #region Constants
        private const int MAX_NUM_OF_BOATS = 400;
        #endregion

        #region Fields
        private Boat[] arrayOfBoats;
        #endregion

        #region Properties
        public Boat[] ArrayOfBoats
        {
            get
            {
                return arrayOfBoats;
            }
        }
        #endregion

        #region Constructor
        public MyDataStorerForBoats(string filePath)
        {
            this.arrayOfBoats = new Boat[MAX_NUM_OF_BOATS];

            // Populate MyDataStorer.
            new MyFileReader(filePath, arrayOfBoats);
        }
        #endregion


        public static void TryValidateField(int fieldIndex, string field)
        {
            switch (fieldIndex)
            {
                case Boat.FIELD_BOAT_TYPE_INDEX:
                    validateType(field);
                    break;
                case Boat.FIELD_REG_NUM_INDEX:
                    validateRegNum(field);
                    break;
                case Boat.FIELD_LENGTH_INDEX:
                    validateLength(field);
                    break;
                case Boat.FIELD_MANUFACTURER_INDEX:
                    validateManufacturer(field);
                    break;
                case Boat.FIELD_YEAR_INDEX:
                    validateYear(field);
                    break;
            }
        }

        private static void validateYear(string field)
        {
            validateAllNumbers(field);
        }

        private static void validateManufacturer(string field)
        {
            validateAllLettersAndNumbers(field);
        }

        private static void validateLength(string field)
        {
            validateAllNumbers(field);
        }

        private static void validateRegNum(string field)
        {
            validateAllNumbers(field);
        }

        private static void validateType(string field)
        {
            validateAllLetters(field);
        }

        // TODO: Put these in the abstract method.
        private static void validateAllLetters(string field)
        {
            foreach (char ch in field)
            {
                if (!Char.IsLetter(ch))
                {
                    throw new MyInvalidFieldException();
                }
            }
        }

        private static void validateAllNumbers(string field)
        {
            foreach (char ch in field)
            {
                if (!Char.IsDigit(ch))
                {
                    throw new MyInvalidFieldException();
                }
            }
        }

        private static void validateAllLettersAndNumbers(string field)
        {
            foreach (char ch in field)
            {
                if ((!Char.IsLetter(ch)) &&
                    (!Char.IsDigit(ch)))
                {
                    throw new MyInvalidFieldException();
                }
            }
        }
    }
}
