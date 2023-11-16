namespace _10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int number = 1; number <= n; number++)
            {
                if (IsTopNumber(number))
                {
                    Console.WriteLine(number);
                }
            }
        }

        static bool IsTopNumber(int number)
        {
            if (HasEvenDigit(number) && IsSumOfDigitsDivisibleBy8(number))
            {
                return true;
            }
            return false;
        }

        static bool HasEvenDigit(int number)
        {
            while (number > 0)
            {
                int digit = number % 10;
                if (digit % 2 == 1)
                {
                    return true;
                }
                number /= 10;
            }
            return false;
        }

        static bool IsSumOfDigitsDivisibleBy8(int number)
        {
            int sumOfDigits = 0;

            while (number > 0)
            {
                int digit = number % 10;
                sumOfDigits += digit;
                number /= 10;
            }

            return sumOfDigits % 8 == 0;
        }
    }
}