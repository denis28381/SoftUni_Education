using System;
namespace _09._Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            double dal = double.Parse(Console.ReadLine());
            double shir = double.Parse(Console.ReadLine());
            double viso = double.Parse(Console.ReadLine());
            double proc = double.Parse(Console.ReadLine());

            double obem = dal * shir * viso;
            double oblit = obem / 1000;
            double zaeto = proc / 100;
            double lit = oblit * (1 - zaeto);

            Console.WriteLine(lit);
        }
    }
}