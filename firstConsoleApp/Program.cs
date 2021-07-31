using System;

namespace firstConsoleApp
{
    class Program
    {
        
        static void Main(string[] args)
        {

            Console.WriteLine("your trip cost: " + TripCost(2, 2, 2));


            Console.ReadKey();
        }

        public static decimal TripCost(decimal numTickets, decimal numPopcorn, decimal numSodas)
        {
            decimal ticketCost = 8.00m;
            decimal popcornCost = 3.50m;
            decimal sodaCost = 2.75m;

            return (ticketCost * numTickets) + (popcornCost * numPopcorn) + (sodaCost * numSodas);
        }

        
        
    }
}
