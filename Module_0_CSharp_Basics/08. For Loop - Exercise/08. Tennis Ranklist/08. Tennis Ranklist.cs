using System;
namespace _08._Tennis_Ranklist
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());
            double pt = 0;
            double avr = 0;
            double wins = 0;

            for (int i = 0; i < n; i++)
            {
                string result = Console.ReadLine();

                switch (result)
                {
                    case "W":
                        pt += 2000;
                        wins++;
                        break;
                    case "F":
                        pt += 1200;
                        break;
                    case "SF":
                        pt += 720;
                        break;
                }
            }
            p += pt;
            avr = pt / n;

            wins = (wins / n) * 100;

            Console.WriteLine($"Final points: {p}");
            Console.WriteLine($"Average points: {Math.Floor(avr):f0}");
            Console.WriteLine($"{wins:f2}%");
        }
    }
}