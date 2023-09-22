using System;
namespace _03._New_House
{
    class Program
    {
        static void Main(string[] args)
        {


            string flowersType = Console.ReadLine();
            int flowersCount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double price = 0;
            if (flowersType == "Roses") { price = 5; }
            else if (flowersType == "Dahlias") { price = 3.8; }
            else if (flowersType == "Tulips") { price = 2.8; }
            else if (flowersType == "Narcissus") { price = 3; }
            else if (flowersType == "Gladiolus") { price = 2.5; }

            double totalCosts = price * flowersCount;

            if (flowersType == "Roses" && flowersCount > 80)
            {
                totalCosts = totalCosts - 0.1 * totalCosts;
            }
            else if ((flowersType == "Dahlias" && flowersCount > 90)
                || (flowersType == "Tulips" && flowersCount > 80))
            {
                totalCosts = totalCosts - 0.15 * totalCosts;
            }
            else if (flowersType == "Narcissus" && flowersCount < 120)
            {
                totalCosts = totalCosts + 0.15 * totalCosts;
            }
            else if (flowersType == "Gladiolus" && flowersCount < 80)
            {
                totalCosts = totalCosts + 0.20 * totalCosts;
            }

            if (budget >= totalCosts)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowersCount} {flowersType} and {budget - totalCosts:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {totalCosts - budget:f2} leva more.");
            }
        }
    }
}