using System;
using System.Collections.Generic;
using System.Text;

namespace StockSystemLibrary
{
    public class NoProductException : Exception
    {
        public NoProductException(string message) : base(message) { }
    }
}
