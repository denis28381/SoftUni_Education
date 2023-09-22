using System;
namespace _10._Odd_Even_Sum
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
                if (i % 2 == 0)
                {
                    firstSum += currentNum;
                }
                else
                {
                    secondSum += currentNum;
                }


            }



            if (firstSum == secondSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {firstSum}");
            }
            else if (secondSum != firstSum)
            {
                int diff = firstSum - secondSum;
                diff = Math.Abs(diff);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }

        }
    }
}