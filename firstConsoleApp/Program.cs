using System;

namespace firstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] prices = { 12.35m, 14.33m, 19.95m };
            decimal totalPrice = 0.0m;

            foreach (decimal price in prices)
            {
                totalPrice += price;
            }

            Console.WriteLine("the total bill is " + totalPrice);
            Console.ReadKey();

        }
    }
}


