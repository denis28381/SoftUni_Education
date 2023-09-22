using System;
namespace _06._World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {

            double rInS = double.Parse(Console.ReadLine());
            double dInM = double.Parse(Console.ReadLine());
            double tPerMInS = double.Parse(Console.ReadLine());

            double totalT = dInM * tPerMInS + Math.Floor(dInM / 15) * 12.5;

            if (totalT < rInS)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalT:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {totalT - rInS:f2} seconds slower.");
            }

        }
    }
}