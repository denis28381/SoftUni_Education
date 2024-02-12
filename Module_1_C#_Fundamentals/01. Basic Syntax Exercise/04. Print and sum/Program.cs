using System;
namespace _04._Print_and_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int total = 0;

            for (int i = a; i <= b; i++)
            {
                Console.Write($"{a} ");
                total += a;
                a++;
            }
            Console.WriteLine($"\nSum: {total}");
        }
    }
}