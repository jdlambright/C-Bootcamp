using System;

namespace firstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            bool[] statements = { false, true, false, false, false, true };
            int falseCount = 0;
            int trueCount = 0;

            foreach (bool statement in statements)
            {
                if (statement == true)
                {
                    trueCount++;
                }
                else
                {
                    falseCount++;
                }
            }

            if(trueCount > falseCount)
            {
                Console.WriteLine("There are more true statements");

            }
            else
            {
                Console.WriteLine("There are more false statements");
            }


            Console.ReadKey();
       }
    }
}


