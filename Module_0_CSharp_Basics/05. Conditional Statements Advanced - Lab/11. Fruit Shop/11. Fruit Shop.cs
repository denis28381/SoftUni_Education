using System;
namespace _11._Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string item = Console.ReadLine();
            string day = Console.ReadLine();
            double qt = double.Parse(Console.ReadLine());
            double total = 0;

            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                double banana = 2.50;
                double apple = 1.20;
                double orange = 0.85;
                double grapefruit = 1.45;
                double kiwi = 2.70;
                double pineapple = 5.50;
                double grapes = 3.85;

                switch (item)
                {
                    case "banana":
                        total = banana * qt;
                        break;
                    case "apple":
                        total = apple * qt;
                        break;
                    case "orange":
                        total = orange * qt;
                        break;
                    case "grapefruit":
                        total = grapefruit * qt;
                        break;
                    case "kiwi":
                        total = kiwi * qt;
                        break;
                    case "pineapple":
                        total = pineapple * qt;
                        break;
                    case "grapes":
                        total = grapes * qt;
                        break;
                    default:
                        Console.WriteLine("error");
                        return;
                        break;

                }
            }
            else if (day == "Saturday" || day == "Sunday")
            {
                double banana = 2.70;
                double apple = 1.25;
                double orange = 0.90;
                double grapefruit = 1.60;
                double kiwi = 3.00;
                double pineapple = 5.60;
                double grapes = 4.20;

                switch (item)
                {
                    case "banana":
                        total = banana * qt;
                        break;
                    case "apple":
                        total = apple * qt;
                        break;
                    case "orange":
                        total = orange * qt;
                        break;
                    case "grapefruit":
                        total = grapefruit * qt;
                        break;
                    case "kiwi":
                        total = kiwi * qt;
                        break;
                    case "pineapple":
                        total = pineapple * qt;
                        break;
                    case "grapes":
                        total = grapes * qt;
                        break;
                    default:
                        Console.WriteLine("error");
                        return;
                        break;
                }
            }
            else
            {
                Console.WriteLine("error");
                return;
            }
            //  total.ToString("#.##");
            // double twoDec = Math.Round(total, 2);
            //  Console.WriteLine(twoDec);
            Console.WriteLine(total.ToString("0.00"));
        }
    }
}