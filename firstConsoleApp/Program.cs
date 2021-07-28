using System;

namespace firstConsoleApp
{
    class Program
    {
        static decimal FunctionReturnDecimal()
        {
            return 10.4m;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("the function returns: " + Program.FunctionReturnDecimal());
            Console.ReadKey();
        }

        
    }
}


