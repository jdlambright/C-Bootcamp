using System;

namespace firstConsoleApp
{
    class Program
    {

        static void Main(string[] args)
        {
            string message = "the word I am going to cut out is: chicken, but leave this part";
            int word = message.IndexOf("chicken");

            string shortString = message.Substring(message.IndexOf("chicken"), "chicken".Length);


            Console.WriteLine(shortString);
            


            Console.ReadKey();
        }
    }
}
