using System;
using System.Collections.Generic;
using System.Text;

namespace firstConsoleApp
{
    class Farm
    {
        public int totalCropsHarvested;
        public int cropsCurrentlyPlanted;
        public int maxCropsPlanted;

        public Farm(int harvested, int current, int max)
        {
            totalCropsHarvested = harvested;
            cropsCurrentlyPlanted = current;
            maxCropsPlanted = max;
        }

        public void HarvestCrops()
        {
            totalCropsHarvested += cropsCurrentlyPlanted;
            cropsCurrentlyPlanted = 0;
        }

        public void PlantCrops(int cropsToPlant)
        {
            if ((cropsToPlant + cropsCurrentlyPlanted) > maxCropsPlanted)
            {
                cropsCurrentlyPlanted = maxCropsPlanted;
            }
            else
            {
                cropsCurrentlyPlanted += cropsToPlant;
            }
        }

    }
}
