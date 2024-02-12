using System;
using System.Collections.Generic;

namespace TheHuntingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int players = int.Parse(Console.ReadLine());
            double energy = double.Parse(Console.ReadLine());
            double waterPerPerson = double.Parse(Console.ReadLine());
            double foodPerPerson = double.Parse(Console.ReadLine());

            List<double> energyLossPerDay = new List<double>();

            for (int day = 0; day < days; day++)
            {
                energyLossPerDay.Add(double.Parse(Console.ReadLine()));

                double waterNeeded = players * waterPerPerson;
                double foodNeeded = players * foodPerPerson;

                energy -= energyLossPerDay[day];
                if (energy <= 0)
                {
                    double foodLeft = foodNeeded * (days - day);
                    double waterLeft = waterNeeded * (days - day);
                    Console.WriteLine($"You will run out of energy. You will be left with {foodLeft:F2} food and {waterLeft:F2} water.");
                    return;
                }

                if ((day + 1) % 2 == 0)
                {
                    double waterConsumed = Math.Min(waterNeeded * 0.30, waterNeeded);
                    waterNeeded -= waterConsumed;
                    energy *= 1.05;
                }

                if ((day + 1) % 3 == 0)
                {
                    double foodConsumed = Math.Min(foodNeeded / players, foodNeeded);
                    foodNeeded -= foodConsumed;
                    energy *= 1.1;
                }
            }

            if (energy > 0)
            {
                Console.WriteLine($"You are ready for the quest. You will be left with {energy:F2} energy!");
            }
        }
    }
}