using System;
namespace _07._Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int min = int.MaxValue;

            while (num != "Stop")
            {
                if (int.Parse(num) < min)
                {
                    min = int.Parse(num);
                }

                num = Console.ReadLine();
            }
            Console.WriteLine(min);
        }
    }
}