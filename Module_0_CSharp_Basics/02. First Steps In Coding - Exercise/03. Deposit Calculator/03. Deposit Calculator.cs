using System;
namespace _03._Deposit_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int time = int.Parse(Console.ReadLine());
            double per = double.Parse(Console.ReadLine());

            double rper = per / 100;

            double totalper = money * rper;
            double per1m = totalper / 12;
            double total = money + time * per1m;

            Console.WriteLine(total);
        }
    }
}