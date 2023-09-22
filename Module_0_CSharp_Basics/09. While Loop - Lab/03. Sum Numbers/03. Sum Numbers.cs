using System;
namespace _03._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            bool w = true;

            while (w)
            {
                int a = int.Parse(Console.ReadLine());
                sum += a;
                if (sum >= n)
                {
                    Console.WriteLine(sum);
                    w = false;
                    return;
                }
            }
        }
    }
}