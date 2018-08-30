using System;
using System.Runtime.Serialization;

namespace Assignment7
{
    [Serializable]
    public class MyInvalidFieldException : Exception
    {
        private const string DEFAULT_ERROR_MESSAGE = "Exception of type MyInvalidFieldException.";
        public MyInvalidFieldException() : this(DEFAULT_ERROR_MESSAGE)
        {
        }

        public MyInvalidFieldException(string message) : base(message)
        {
            // DEBUG
            MyDebugger.ShowComment(message);
        }


    }
}