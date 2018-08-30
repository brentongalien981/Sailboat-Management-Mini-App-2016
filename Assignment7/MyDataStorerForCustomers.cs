using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    class MyDataStorerForCustomers
    {
        #region Constants
        private const int MAX_NUM_OF_CUSTOMERS = 400;
        #endregion

        #region Fields
        private Customer[] arrayOfCustomers;
        #endregion

        #region Properties
        public Customer[] ArrayOfCustomers
        {
            get
            {
                return arrayOfCustomers;
            }
        }
        #endregion

        #region Constructor
        public MyDataStorerForCustomers(string filePath)
        {
            this.arrayOfCustomers = new Customer[MAX_NUM_OF_CUSTOMERS];

            // Populate MyDataStorer.
            new MyFileReader(filePath, arrayOfCustomers);
        }
        #endregion



        public static void TryValidateField(int fieldIndex, string field)
        {
            switch (fieldIndex)
            {
                case Customer.FIELD_NAME_INDEX:
                    validateName(field);
                    break;
                case Customer.FIELD_ADDRESS_INDEX:
                    validateAddress(field);
                    break;
                case Customer.FIELD_TELNUM_INDEX:
                    validatePhone(field);
                    break;
            }
        }

        private static void validatePhone(string field)
        {
            validateAllNumbers(field);
        }

        private static void validateAddress(string field)
        {
            validateAllLettersAndNumbers(field);
        }

        private static void validateName(string field)
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
                if ((!Char.IsLetter(ch))  &&
                    (!Char.IsDigit(ch)))
                {
                    throw new MyInvalidFieldException();
                }
            }
        }
    }
}
