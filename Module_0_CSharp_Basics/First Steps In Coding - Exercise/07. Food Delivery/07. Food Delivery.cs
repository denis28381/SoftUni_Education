using System;
namespace _07._Food_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int ciken = int.Parse(Console.ReadLine());
            int fish = int.Parse(Console.ReadLine());
            int veg = int.Parse(Console.ReadLine());

            double cikenPr = 10.35;
            double fishPr = 12.40;
            double vegPr = 8.15;
            double delivery = 2.50;

            double totalCiken = ciken * cikenPr;
            double totalFish = fish * fishPr;
            double totalVeg = veg * vegPr;
            double total = totalCiken + totalFish + totalVeg;
            double des = 0.20 * total;
            double all = total + des + 2.50;

            Console.WriteLine(all);
        }
    }
}