using System;
using System.Collections.Generic;
using System.Text;

namespace firstConsoleApp
{
    class Bicycle
    {
        public int currentGear = 1;
        public int topGear;

        public Bicycle(int top)
        {
            topGear = top;
        }

        public void ShiftGear(int gearToSet)
        {
            if (gearToSet <= topGear && gearToSet - currentGear == 1 || gearToSet - currentGear == -1 )
            {
                currentGear = gearToSet;
            }
            else
            {
                Console.WriteLine("please enter valid gear");
            }
        }
    }
}
