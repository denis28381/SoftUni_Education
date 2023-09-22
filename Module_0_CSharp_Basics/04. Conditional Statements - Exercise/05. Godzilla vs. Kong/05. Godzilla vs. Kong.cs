using System;
namespace _05._Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {

            double budget = double.Parse(Console.ReadLine());
            int statistsCount = int.Parse(Console.ReadLine());
            double clothingPricePerStatist = double.Parse(Console.ReadLine());

            double decorCosts = 0.1 * budget;
            double clothingCost = statistsCount * clothingPricePerStatist;
            if (statistsCount > 150)
            {
                clothingCost = clothingCost - 0.1 * clothingCost;
            }

            double totalCosts = decorCosts + clothingCost;

            if (budget >= totalCosts)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget - totalCosts:f2} leva left.");

            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {totalCosts - budget:f2} leva more.");
            }

        }
    }
}