using System;
namespace _06._Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int cake = a * b;

            while (cake > 0)
            {
                string take = Console.ReadLine();

                if (take == "STOP")
                {
                    Console.WriteLine($"{cake} pieces are left.");
                    return;
                }

                int takeInt = int.Parse(take);


                cake -= takeInt;

                if (cake < 0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(cake)} pieces more.");
                    return;
                }


            }
        }
    }
}