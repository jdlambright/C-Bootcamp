using System;

namespace firstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal decimalValue = 3.25m;
            decimal valueOfPi = 3.1415m;
            string message = "DecimalValue is not equal to pi";

            if (decimalValue == valueOfPi)
            {
                message = "DecimalValue is equal to pi";
            }


        }
    }
}
