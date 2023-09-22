using System;
namespace _04._Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {



            int budget = int.Parse(Console.ReadLine());

            string season = Console.ReadLine();
            int fishermenCount = int.Parse(Console.ReadLine());


            double costs = 0;
            if (season == "Spring") { costs = 3000; }
            else if (season == "Summer" || season == "Autumn") { costs = 4200; }
            else if (season == "Winter") { costs = 2600; }

            if (fishermenCount <= 6)
            {
                costs = costs - 0.10 * costs;
            }
            else if (fishermenCount <= 11)
            {
                costs = costs - 0.15 * costs;
            }
            else
            {
                costs = costs - 0.25 * costs;
            }


            if (fishermenCount % 2 == 0 && season != "Autumn")
            {
                costs = costs - 0.05 * costs;
            }


            if (budget >= costs)
            {
                Console.WriteLine($"Yes! You have {budget - costs:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {costs - budget:f2} leva.");
            }

        }
    }
}
