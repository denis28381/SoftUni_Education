using System;
namespace _08._Basketball_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double tax = double.Parse(Console.ReadLine());

            double kec = tax - ((tax / 100) * 40);
            double ekip = kec - (0.20 * kec);
            double topka = ekip / 4;
            double aks = topka / 5;

            double all = tax + kec + ekip + topka + aks;

            Console.WriteLine(all);
        }
    }
}