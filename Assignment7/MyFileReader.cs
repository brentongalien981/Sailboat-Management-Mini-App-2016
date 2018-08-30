using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment7
{
    class MyFileReader
    {
        private const char DELIMETER = ',';

        private FileStream myFileStream;
        private StreamReader myStreamReader;
        private Object[] anArray;
        private int counter;

        public MyFileReader(string filePath, Customer[] arrayOfCustomers)
        {
            this.anArray = arrayOfCustomers;
            this.counter = 0;
            prepareMyStreamReader(filePath);
            processFile();
            closeMyReader();            
        }

        public MyFileReader(string filePath, Boat[] arrayOfBoats)
        {
            this.anArray = arrayOfBoats;
            this.counter = 0;
            prepareMyStreamReader(filePath);
            processFileForBoats();
            closeMyReader();
        }

        private void prepareMyStreamReader(string filePath)
        {
            try
            {
                myFileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                myStreamReader = new StreamReader(myFileStream);
            }
            catch (FileNotFoundException fnfe)
            {
                Console.WriteLine("Caught in method prepareMyStreamReader(), catch block fnfe: " + fnfe.Message);
            }
        }

        private void processFile()
        {
            Customer aCustomer;
            string[] customerFields;
            string aCustomerRecord = myStreamReader.ReadLine();

            // Read the file record by record.
            while (aCustomerRecord != null)
            {
                // Break the record into fields.
                customerFields = aCustomerRecord.Split(DELIMETER);

                try
                {
                    // Validate the record.
                    for (int i = 0; i < Customer.NUMBER_OF_FIELDS; i++)
                    {
                        // This throws a MyInvalidFieldException.
                        MyDataStorerForCustomers.TryValidateField(i, customerFields[i]);
                    }

                    // Once it passes the validation loop....
                    string name = customerFields[Customer.FIELD_NAME_INDEX];
                    string address = customerFields[Customer.FIELD_ADDRESS_INDEX];
                    string telephoneNumber = customerFields[Customer.FIELD_TELNUM_INDEX];

                    // Create an object Customer with properties from the broken down fields.
                    aCustomer = new Customer(name, address, telephoneNumber);


                    // Add the object Customer to the customer array.
                    anArray[counter++] = aCustomer; 
                }
                catch (IndexOutOfRangeException ioore)
                {
                    Console.WriteLine("Caught in my own method processFile(), catch block ioore: " + ioore.Message);
                }
                catch (MyInvalidFieldException mife)
                {
                    Console.WriteLine("Caught in my own method processFile(), catch block mife: " + mife.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Caught in my own method processFile(), catch block e: " + e.Message);
                }

                // Read the next record.
                aCustomerRecord = myStreamReader.ReadLine();
            }
        }

        // TODO: Fix this and create an abstract class instead.
        private void processFileForBoats()
        {
            //Boat theBoat.
            string[] boatFields;
            string aBoatRecord = myStreamReader.ReadLine();

            // Read the file record by record.
            while (aBoatRecord != null)
            {
                // Break the record into fields.
                boatFields = aBoatRecord.Split(DELIMETER);

                try
                {
                    // Validate the record.
                    for (int i = 0; i < Boat.NUMBER_OF_FIELDS; i++)
                    {
                        // This throws a MyInvalidFieldException.
                        MyDataStorerForBoats.TryValidateField(i, boatFields[i]);
                    }

                    // Once it passes the validation loop....
                    // TODO: Create a Boat constants for the indexes.
                    string boatType = boatFields[0];
                    string regNum = boatFields[1];
                    string length = boatFields[2];
                    string manufacturer = boatFields[3];
                    string year = boatFields[4];

                    switch (boatType)
                    {
                        // TODO: Make a method for the repeated codes.
                        case "Boat":
                            Boat aBoat = new Boat(Convert.ToInt32(regNum), Convert.ToInt32(length), manufacturer, Convert.ToInt32(year));
                            // Add the object boat to the boat array.
                            anArray[counter++] = aBoat;
                            break;
                        case "MotorBoat":
                            // Added validation needed for motorboats.
                            // TODO: Make a variable for the indexes.
                            MyDataStorerForBoats.TryValidateField(5, boatFields[5]);
                            MyDataStorerForBoats.TryValidateField(6, boatFields[6]);

                            // If all fields are valid, create an object "MotorBoat".
                            string numOfEngines = boatFields[5];
                            string fuelType = boatFields[6];

                            MotorBoat aMotorBoat = new MotorBoat(Convert.ToInt32(regNum), Convert.ToInt32(length), manufacturer, Convert.ToInt32(year), Convert.ToInt32(numOfEngines), fuelType);

                            // Add the object to the boat array.
                            anArray[counter++] = aMotorBoat;
                            break;
                        case "SailBoat":
                            // Added validation needed for sailboats.
                            // TODO: Make a variable for the indexes.
                            MyDataStorerForBoats.TryValidateField(5, boatFields[5]);
                            MyDataStorerForBoats.TryValidateField(6, boatFields[6]);

                            // If all fields are valid, create an object "SailBoat".
                            string numOfSails = boatFields[5];
                            string numOfMasts = boatFields[6];

                            SailBoat aSailBoat = new SailBoat(Convert.ToInt32(regNum), Convert.ToInt32(length), manufacturer, Convert.ToInt32(year), Convert.ToInt32(numOfSails), Convert.ToInt32(numOfMasts));

                            // Add the object boat to the boat array.
                            anArray[counter++] = aSailBoat;
                            break;
                    }
                }
                catch (IndexOutOfRangeException ioore)
                {
                    Console.WriteLine("Caught in my own method processFileForBoat(), catch block ioore: " + ioore.Message);
                }
                catch (MyInvalidFieldException mife)
                {
                    Console.WriteLine("Caught in my own method processFile(), catch block mife: " + mife.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Caught in my own method processFileForBoat(), catch block e: " + e.Message);
                }

                // Read the next record.
                aBoatRecord = myStreamReader.ReadLine();
            }
        }

        private void closeMyReader()
        {
            myStreamReader.Close();
            myFileStream.Close();
        }
    }
}
