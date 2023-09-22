using System;
namespace _05._Supplies_for_School
{
    class Program
    {
        static void Main(string[] args)
        {
            int Pens = int.Parse(Console.ReadLine());
            int Mark = int.Parse(Console.ReadLine());
            int Preparat = int.Parse(Console.ReadLine());
            double Disc = int.Parse(Console.ReadLine());

            double DiscRe = Disc / 100;

            double PenPr = 5.80;
            double MarkPr = 7.20;
            double PrepaPr = 1.20;

            double PensTotal = Pens * PenPr;
            double MarkTotal = Mark * MarkPr;
            double PrepTotal = Preparat * PrepaPr;

            double all = PensTotal + MarkTotal + PrepTotal;
            double allWithDisc = all - (DiscRe * all);

            Console.WriteLine(allWithDisc);
        }
    }
}