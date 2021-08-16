using System;

namespace firstConsoleApp
{
    class Program 
    {

        static void Main(string[] args)
        {
            Shape triangle = new Shape(3, new int[] { 4, 7, 2 });

            Console.WriteLine($"Number of sides: {triangle.numberOfSides}");
            foreach(int side in triangle.sideLengths)
            {
                Console.Write($"{side}, ");
            }
            Console.WriteLine();
            Console.WriteLine($"Perimeter: {triangle.CalculatePerimeter()}");
            

            Console.ReadKey();

        }
    }
}
