using System;
namespace _09._Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int firstSum = 0;
            int secondSum = 0;

            for (int i = 0; i < n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                firstSum += currentNum;


            }

            for (int i = 0; i < n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                secondSum += currentNum;

            }

            if (firstSum == secondSum)
            {
                Console.WriteLine($"Yes, sum = {firstSum}");
            }
            else if (secondSum != firstSum)
            {
                int diff = firstSum - secondSum;
                diff = Math.Abs(diff);
                Console.WriteLine($"No, diff = {diff}");
            }

        }
    }
}