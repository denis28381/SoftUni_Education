using System;
namespace _06._Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int max = int.MinValue;

            while (num != "Stop")
            {
                if (int.Parse(num) > max)
                {
                    max = int.Parse(num);
                }

                num = Console.ReadLine();
            }
            Console.WriteLine(max);
        }
    }
}