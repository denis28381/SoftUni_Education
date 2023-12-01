using System.Diagnostics.CodeAnalysis;

namespace _2._Character_Multiplier
{
    internal class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(" ");

            int reuslt = Sum(input[0], input[1]);
            Console.WriteLine(Sum(input[0], input[1]));
        }

        private static int Sum(string first, string second)
        {
            int sum = 0;

            int lenght = Math.Max(first.Length, second.Length);

            for (int i = 0; i < lenght; i++)
            {
                if (i < first.Length && i < second.Length)
                {
                    sum += first[i] * second[i];
                }
                else if (i < first.Length)
                {
                    sum += first[i];
                }
                else if (i < second.Length)
                {
                    sum += second[i];
                }
            }



            return sum;
        }
    }
}