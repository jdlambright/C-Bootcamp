using System;

namespace firstConsoleApp
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("the highest value is: ");
            Console.WriteLine(GetHigherValue(3, 7));


            Console.ReadKey();
        }

        public static int GetHigherValue(int firstValue, int secondValue)
        {
            if (firstValue > secondValue)
            {
                return firstValue;
            }
            return secondValue;
        }

    }
}
