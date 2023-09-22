using System;
namespace _07.Working_Hours
{
    class Program
    {
        static void Main(string[] args)
        {
            double t = double.Parse(Console.ReadLine());
            string d = Console.ReadLine();

            if (d == "Sunday")
            {
                Console.WriteLine("closed");
            }
            else if (t < 10 || t > 18)
            {
                Console.WriteLine("closed");
            }
            else if (t > 10 & t < 18)
            {
                Console.WriteLine("open");
            }
        }
    }
}

//85//100