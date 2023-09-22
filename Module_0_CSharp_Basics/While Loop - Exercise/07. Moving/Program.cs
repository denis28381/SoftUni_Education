using System;
namespace _07._Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int FreeSpace = a * b * c;

            while (FreeSpace > 0)
            {
                string box = Console.ReadLine();

                if (box == "Done")
                {
                    Console.WriteLine($"{FreeSpace} Cubic meters left.");
                    return;
                }

                int takeInt = int.Parse(box);


                FreeSpace -= takeInt;

                if (FreeSpace < 0)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(FreeSpace)} Cubic meters more.");
                    return;
                }


            }
        }
    }
}