using System;
namespace _03._Histogram
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            double p1 = 0; //< 200
            double p2 = 0; //200-399
            double p3 = 0; //400-599
            double p4 = 0; //600-799
            double p5 = 0; //>= 800

            for (int i = 1; i <= n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());

                if (currentNum < 200)
                {
                    p1++;
                }
                if (currentNum >= 200 && currentNum <= 399)
                {
                    p2++;
                }
                if (currentNum >= 400 && currentNum <= 599)
                {
                    p3++;
                }
                if (currentNum >= 600 && currentNum <= 799)
                {
                    p4++;
                }
                if (currentNum >= 800)
                {
                    p5++;
                }
            }

            p1 = p1 / n * 100;
            p2 = p2 / n * 100;
            p3 = p3 / n * 100;
            p4 = p4 / n * 100;
            p5 = p5 / n * 100;

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");
        }
    }
}