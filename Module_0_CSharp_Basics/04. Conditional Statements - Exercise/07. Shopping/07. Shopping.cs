using System;
namespace _07._Shopping
{
    class Program
    {
        static void Main(string[] args)
        {

            double budget = double.Parse(Console.ReadLine());
            int gpuCount = int.Parse(Console.ReadLine());
            int cpuCount = int.Parse(Console.ReadLine());
            int ramCount = int.Parse(Console.ReadLine());

            double gpuCosts = gpuCount * 250;
            double cpuCosts = cpuCount * 0.35 * gpuCosts;
            double ramCosts = ramCount * 0.1 * gpuCosts;

            double totalCosts = gpuCosts + cpuCosts + ramCosts;

            if (gpuCount > cpuCount)
            {
                totalCosts = totalCosts - 0.15 * totalCosts;
            }

            if (budget >= totalCosts)
            {
                Console.WriteLine($"You have {budget - totalCosts:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {totalCosts - budget:f2} leva more!");
            }


        }
    }
}