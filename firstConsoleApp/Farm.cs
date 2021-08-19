using System;
using System.Collections.Generic;
using System.Text;

namespace firstConsoleApp
{
    class Farm
    {
        //fields
        public int totalCropsHarvested = 0;
        public int cropsCurrentlyPlanted = 0;
        public int maxCropsPlanted = -1;
        
        public Farm(int maxCrops)
        {
            maxCropsPlanted = maxCrops;
        }

        public void HarvestCrops()
        {
            totalCropsHarvested += cropsCurrentlyPlanted;
            cropsCurrentlyPlanted = 0;
        }

        public void PlantCrops(int cropsToPlant)
        {

            if( (cropsCurrentlyPlanted + cropsToPlant) > maxCropsPlanted)
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
