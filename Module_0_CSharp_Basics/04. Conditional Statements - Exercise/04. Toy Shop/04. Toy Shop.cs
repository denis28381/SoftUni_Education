using System;
namespace _04._Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {

            double eks = Double.Parse(Console.ReadLine());
            int brpaz = int.Parse(Console.ReadLine());
            int brkuk = int.Parse(Console.ReadLine());
            int brmec = int.Parse(Console.ReadLine());
            int brmin = int.Parse(Console.ReadLine());
            int brkam = int.Parse(Console.ReadLine());

            double pazel = 2.60;
            double kukla = 3;
            double meche = 4.10;
            double minion = 8.20;
            double kamionche = 2;

            double toysum = brpaz * pazel + brkuk * kukla + brmec * meche + brmin * minion + brkam * kamionche;
            int toys = brpaz + brkuk + brmec + brmin + brkam;
            double sum = toysum;
            if (toys > 50)
            {
                double disc = toysum * 0.25;
                sum = toysum - disc;
            }
            double naem = sum * 0.1;
            sum -= naem;

            if (sum >= eks)
            {
                sum -= eks;
                Double nc = sum;
                Console.WriteLine($"Yes! {Math.Round((Double)nc, 2):f2} lv left.");
            }
            else
            {
                double n = eks - sum;
                Double nc = n;
                Console.WriteLine($"Not enough money! {Math.Round((Double)n, 2):f2} lv needed.");
            }


        }
    }
}