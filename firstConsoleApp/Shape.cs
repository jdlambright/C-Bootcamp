using System;
using System.Collections.Generic;
using System.Text;

namespace firstConsoleApp
{
    class Shape
    {
        public int numberOfSides = 0;
        public int[] sideLengths;

        public Shape(int sides, int[] lengths)
        {
            numberOfSides = sides;
            sideLengths = lengths;
        }

        public int CalculatePerimeter()
        {
            int perimeter = 0;

            foreach (int length in sideLengths)
            {
                perimeter += length;

            }
            return perimeter;
        }
    }
}
