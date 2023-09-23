using Microsoft.VisualBasic;

namespace _09._Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double yield = double.Parse(Console.ReadLine());

            double spices = 0;
            int days = 0;

            while (yield >= 100)
            {
                spices += yield;
                days++;
                yield -= 10;
                if(spices - 26 - 26 >= 0)
                {
                    spices -= 26;
                }
                else { break; }
                    

            }
            spices -= 26;

            Console.WriteLine(days);
            Console.WriteLine(spices);
        }
    }
}