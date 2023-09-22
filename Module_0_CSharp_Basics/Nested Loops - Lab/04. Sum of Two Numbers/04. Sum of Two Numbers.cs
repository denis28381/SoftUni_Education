using System;
namespace _04._Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int res = int.Parse(Console.ReadLine());

            int count = 0;

            for (int a = num1; a <= num2; a++)
            {
                for (int b = num1; b <= num2; b++)
                {
                    count++;
                    if (a + b == res)
                    {
                        Console.WriteLine($"Combination N:{count} ({a} + {b} = {res})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{count} combinations - neither equals {res}");
        }
    }
}