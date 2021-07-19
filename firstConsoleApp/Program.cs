using System;

namespace firstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] calories = { 800, 850, 300 };
            int dailyCalorieDiet = 2000;
            int totalCalories = 0;

            foreach (int cal in calories)
            {
                totalCalories = totalCalories + cal;
            }

            Console.WriteLine("calorie percentage of " + dailyCalorieDiet + " calorie diet: " + ((decimal)totalCalories / (decimal)dailyCalorieDiet) * 100 + "%");
            Console.ReadKey();
       }
    }
}


