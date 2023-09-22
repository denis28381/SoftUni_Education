using System;
namespace _06._Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            int naiKol = int.Parse(Console.ReadLine());
            int boqKol = int.Parse(Console.ReadLine());
            int RazKol = int.Parse(Console.ReadLine());
            double time = int.Parse(Console.ReadLine());

            double nailon = 1.50;
            double boq = 14.50;
            double razreditel = 5.00;
            double bag = 0.40;
            double a = 0.10 * boqKol;
            int b = 2;

            double naiPr = (naiKol + b) * nailon;
            double boqPr = (boqKol + a) * boq;
            double razpr = RazKol * razreditel;
            double totalMat = naiPr + boqPr + razpr + bag;
            double maistor = (totalMat * 0.30) * time;
            double all = totalMat + maistor;

            Console.WriteLine(all);
        }
    }
}