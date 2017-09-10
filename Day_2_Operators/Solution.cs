using System;
namespace Restaurant
{
    class Restaurant
    {
        public static void Main()
        {
            double mealCost = Convert.ToDouble(Console.ReadLine());
            double tip = mealCost * Convert.ToDouble(Console.ReadLine())/100;
            double tax = mealCost * Convert.ToDouble(Console.ReadLine())/100;

            double totalCost = mealCost + tip  + tax;

            Console.WriteLine("The total meal cost is "+Math.Round(totalCost)+" dollars.");
        }
    }
}