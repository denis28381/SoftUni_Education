using System;
namespace _01._Integer_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int add = a + b;

            int c = int.Parse(Console.ReadLine());

            int devide = add / c;

            int d = int.Parse(Console.ReadLine());

            int multiply = devide * d;

            Console.WriteLine(multiply);
        }
    }
}