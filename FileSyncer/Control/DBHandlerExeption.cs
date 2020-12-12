using System;
using System.Runtime.Serialization;

namespace FileSyncer
{
    [Serializable]
    internal class DBHandlerExeption : Exception
    {
        public DBHandlerExeption(string message, Exception innerException) : base(message, innerException)
        {
        }


    }
}