using System;
namespace _05._Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string item = Console.ReadLine();
            string city = Console.ReadLine();
            double qt = double.Parse(Console.ReadLine());
            double total = 0;

            if (city == "Sofia")
            {
                double coffee = 0.50;
                double water = 0.80;
                double beer = 1.20;
                double sweets = 1.45;
                double peanuts = 1.60;

                switch (item)
                {
                    case "coffee":
                        total = coffee * qt;
                        break;
                    case "water":
                        total = water * qt;
                        break;
                    case "beer":
                        total = beer * qt;
                        break;
                    case "sweets":
                        total = sweets * qt;
                        break;
                    case "peanuts":
                        total = peanuts * qt;
                        break;
                }
            }
            else if (city == "Plovdiv")
            {
                double coffee = 0.40;
                double water = 0.70;
                double beer = 1.15;
                double sweets = 1.30;
                double peanuts = 1.50;

                switch (item)
                {
                    case "coffee":
                        total = coffee * qt;
                        break;
                    case "water":
                        total = water * qt;
                        break;
                    case "beer":
                        total = beer * qt;
                        break;
                    case "sweets":
                        total = sweets * qt;
                        break;
                    case "peanuts":
                        total = peanuts * qt;
                        break;
                }
            }
            else if (city == "Varna")
            {
                double coffee = 0.45;
                double water = 0.70;
                double beer = 1.10;
                double sweets = 1.35;
                double peanuts = 1.55;

                switch (item)
                {
                    case "coffee":
                        total = coffee * qt;
                        break;
                    case "water":
                        total = water * qt;
                        break;
                    case "beer":
                        total = beer * qt;
                        break;
                    case "sweets":
                        total = sweets * qt;
                        break;
                    case "peanuts":
                        total = peanuts * qt;
                        break;
                }
            }

            Console.WriteLine(total);
        }
    }
}