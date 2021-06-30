using System;

namespace firstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            int tomatoes = 25;
            decimal price = 3.25M;

            decimal result = (tomatoes - 2) * price;

            Console.WriteLine(result);
        }
    }
}
