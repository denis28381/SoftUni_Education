using System;
namespace _05._Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double bankAccount = 0;

            while (input != "NoMoreMoney")
            {
                double currentAmount = double.Parse(input);

                if (currentAmount < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                bankAccount += currentAmount;

                Console.WriteLine($"Increase: {currentAmount:f2}");

                input = Console.ReadLine();
            }
            Console.WriteLine($"Total: {bankAccount:f2}");
        }
    }
}