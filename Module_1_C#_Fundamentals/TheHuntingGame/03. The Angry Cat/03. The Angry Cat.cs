using System;
using System.Collections.Generic;
using System.Linq;
namespace _03._The_Angry_Cat
{
    internal class Program
    {
        static void Main(string[] args)
        {



            List<int> priceRatings = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToList();
            int entryPoint = int.Parse(Console.ReadLine());
            string itemType = Console.ReadLine();

            List<int> leftDamageItems = new List<int>();
            List<int> rightDamageItems = new List<int>();

            // Calculate damage to the left
            for (int i = 0; i < entryPoint; i++)
            {
                if ((itemType == "cheap" && priceRatings[i] < priceRatings[entryPoint]) ||
                    (itemType == "expensive" && priceRatings[i] >= priceRatings[entryPoint]))
                {
                    leftDamageItems.Add(priceRatings[i]);
                }
            }

            // Calculate damage to the right
            for (int i = entryPoint + 1; i < priceRatings.Count; i++)
            {
                if ((itemType == "cheap" && priceRatings[i] < priceRatings[entryPoint]) ||
                    (itemType == "expensive" && priceRatings[i] >= priceRatings[entryPoint]))
                {
                    rightDamageItems.Add(priceRatings[i]);
                }
            }

            int leftDamage = leftDamageItems.Sum();
            int rightDamage = rightDamageItems.Sum();

            if (leftDamage >= rightDamage)
            {
                Console.WriteLine($"Left - {leftDamage}");
            }
            else
            {
                Console.WriteLine($"Right - {rightDamage}");
            }
        }
    }
}