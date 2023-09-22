using System;
namespace _04._Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            string input = "";
            string name = "";
            double sumCurrent = 0;
            double sum = 0;
            int count = 0;
            input = Console.ReadLine();

            while (input != "Finish")
            {
                name = input;


                sumCurrent = 0;
                for (int i = 1; i <= n; i++)
                {

                    double inputToDouble = double.Parse(Console.ReadLine());
                    sumCurrent += inputToDouble;

                }

                sum += sumCurrent / n;


                count++;

                Console.WriteLine($"{name} - {sumCurrent / n:f2}.");

                input = Console.ReadLine();
            }
            Console.WriteLine($"Student's final assessment is {(sum / count):f2}.");
        }
    }
}