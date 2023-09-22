using System;
namespace _04._Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {

            int age = int.Parse(Console.ReadLine());
            double WashingMachine = double.Parse(Console.ReadLine());
            int toy = int.Parse(Console.ReadLine());
            double money = 0;
            int a = 0;

            for (int i = 1; i <= age; i++)
            {

                if (i % 2 == 0)
                {
                    a += 10;
                    money += a;
                    money--;
                }
                else
                {
                    money += toy;
                }
            }
            if (money >= WashingMachine)
            {
                double left = money - WashingMachine;
                Console.WriteLine($"Yes! {left:f2}");
            }
            else
            {
                double more = WashingMachine - money;
                Console.WriteLine($"No! {more:f2}");
            }
        }
    }
}