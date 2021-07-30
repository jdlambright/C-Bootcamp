using System;

namespace firstConsoleApp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string[] myStrings = { "hello", "world" };

            Console.WriteLine("This number of strings is: " + StringCount(myStrings));

            Console.ReadKey();
        }

        public static int StringCount(string[] myStrings)
        {
            int numStrings = 0;

            foreach (string str in myStrings)
            {
                numStrings++;
            }
            return numStrings;
        }

    }
}


