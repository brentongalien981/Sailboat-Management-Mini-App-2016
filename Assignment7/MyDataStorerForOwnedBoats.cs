using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    class MyDataStorerForOwnedBoats
    {
        #region Constants
        private const int MAX_NUM_OF_OWNERSHIP = 400;
        private const int NUM_OF_FIELDS = 2;
        private const string FILEPATH = "ownership.txt";
        #endregion

        #region Fields
        private string[,] arrayOfPhoneAndRegNumPair;
        private int numOfOwnership;
        #endregion

        public string[,] ArrayOfPhoneAndRegNumPair
        {
            get
            {
                return arrayOfPhoneAndRegNumPair;
            }

        }
        public int NumOfOwnership
        {
            get
            {
                return numOfOwnership;
            }
        }

        public MyDataStorerForOwnedBoats()
        {
            arrayOfPhoneAndRegNumPair = new string[MAX_NUM_OF_OWNERSHIP, NUM_OF_FIELDS];

            // TODO: Update this every loop.
            numOfOwnership = 0;

            // TODO: Use the class "MyFileReader" for this task.
            // Read the file.
            FileStream myFileStream;
            StreamReader myStreamReader;

            try
            {
                myFileStream = new FileStream("ownership.txt", FileMode.Open, FileAccess.Read);
                myStreamReader = new StreamReader(myFileStream);

                string[] ownershipFields;
                string ownershipRecord = myStreamReader.ReadLine();

                // Read the file record by record.
                while (ownershipRecord != null)
                {
                    // Break the record into fields.
                    ownershipFields = ownershipRecord.Split(',');
                    arrayOfPhoneAndRegNumPair[numOfOwnership, 0] = ownershipFields[0];
                    arrayOfPhoneAndRegNumPair[numOfOwnership, 1] = ownershipFields[1];

                    ownershipRecord = myStreamReader.ReadLine();

                    ++numOfOwnership;
                }

                myStreamReader.Close();
                myFileStream.Close();
            }
            catch (FileNotFoundException fnfe)
            {
                Console.WriteLine("Caught in constructor MyDataStorerForOwnedBoats(), catch block fnfe: " + fnfe.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Caught in constructor MyDataStorerForOwnedBoats(), catch block e: " + e.Message);
            }
        }

        public void AssignBoatToOwner(string customerPhoneNum, string boatRegNum)
        {
            arrayOfPhoneAndRegNumPair[numOfOwnership, 0] = customerPhoneNum;
            arrayOfPhoneAndRegNumPair[numOfOwnership, 1] = boatRegNum;

            // DEBUG
            MyDebugger.ShowComment("Ownership assigned: " + arrayOfPhoneAndRegNumPair[numOfOwnership, 0] + ", " + arrayOfPhoneAndRegNumPair[numOfOwnership, 1]);

            ++numOfOwnership;
        }

        public void Save()
        {
            FileStream myFileStream;
            StreamWriter myStreamWriter;

            try
            {
                // Create an input stream and a file writer;
                myFileStream = new FileStream(FILEPATH, FileMode.Create, FileAccess.Write);
                myStreamWriter = new StreamWriter(myFileStream);

                // Write all the records to the file.
                for (int i = 0; i < this.numOfOwnership; i++)
                {
                    myStreamWriter.WriteLine(arrayOfPhoneAndRegNumPair[i, 0] + "," + arrayOfPhoneAndRegNumPair[i, 1]);
                }


                // Close the writer and stream.
                myStreamWriter.Close();
                myFileStream.Close();
            }
            catch (FileNotFoundException fnfe)
            {
                MyDebugger.ShowComment("Caught in class MyDataStorerForOwnedBoats, method Save(), catch block fnfe: " + fnfe.Message);
            }
            catch (Exception e)
            {
                MyDebugger.ShowComment("Caught in class MyDataStorerForOwnedBoats, method Save(), catch block e: " + e.Message);
            }
        }
    }
}
