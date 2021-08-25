using System;
using System.Collections.Generic;
using System.Text;

namespace firstConsoleApp
{
    class Store
    {
        // declaring field names
        public string storeName;
        public int upkeepCost;
        public int grossRevenue;
        public bool makingProfit;

        // making constructor
        public Store(string name, int cost, int revenue)
        {
            storeName = name;
            upkeepCost = cost;
            grossRevenue = revenue;
        }

        //method that tells if store is making or losing money

        public int CalculateProfit()
        {
            int profit = grossRevenue - upkeepCost;
            if (profit > 0)
            {
                makingProfit = true;               
            }
            else
            {
                makingProfit = false;
                
            }
            return profit;
        }
    }
}
