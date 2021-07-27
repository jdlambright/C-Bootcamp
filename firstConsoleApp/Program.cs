using System;

namespace firstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] restaurantRatings = { 5, 3, 2, 4, 5, 3, 2 };
            int minimumRating = 4;
            int meetsMinimum = 0;

            foreach( int rating in restaurantRatings)
            {
                if (rating >= minimumRating)
                {
                    meetsMinimum++;
                }
            }

            Console.WriteLine("total restuarants: " + restaurantRatings.Length);
            Console.WriteLine("meets minimum: " + meetsMinimum);
            Console.ReadKey();

        }
    }
}


