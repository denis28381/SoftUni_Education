using System;
namespace _06._Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalTicketsCount = 0;
            int studentTicketsCount = 0;
            int standardTicketsCount = 0;
            int kidsTicketsCount = 0;

            string movieNmae = Console.ReadLine();
            while (movieNmae != "Finish")
            {
                int capacity = int.Parse(Console.ReadLine());
                int soldTikets = 0;

                string tiketType = Console.ReadLine();
                while (tiketType != "End")
                {
                    if (tiketType == "student")
                    {
                        studentTicketsCount++;
                    }
                    else if (tiketType == "standard")
                    {
                        standardTicketsCount++;
                    }
                    else if (tiketType == "kid")
                    {
                        kidsTicketsCount++;
                    }

                    soldTikets++;
                    if (soldTikets == capacity)
                    {
                        break;
                    }
                    tiketType = Console.ReadLine();
                }

                totalTicketsCount += soldTikets;
                double fillPercentage = 100.0 * soldTikets / capacity;
                Console.WriteLine($"{movieNmae} - {fillPercentage:f2}% full.");
                movieNmae = Console.ReadLine();
            }

            Console.WriteLine($"Total tickets: {totalTicketsCount}");
            Console.WriteLine($"{100.0 * studentTicketsCount / totalTicketsCount:f2}% student tickets.");
            Console.WriteLine($"{100.0 * standardTicketsCount / totalTicketsCount:f2}% standard tickets.");
            Console.WriteLine($"{100.0 * kidsTicketsCount / totalTicketsCount:f2}% kids tickets.");
        }
    }
}