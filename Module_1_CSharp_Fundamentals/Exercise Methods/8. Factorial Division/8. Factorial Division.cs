namespace _8._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            double result = DivideFactorials(number1, number2);

            Console.WriteLine($"{result:F2}");
        }

        static double DivideFactorials(int num1, int num2)
        {
            double factorial1 = CalculateFactorial(num1);
            double factorial2 = CalculateFactorial(num2);

            return factorial1 / factorial2;
        }

        static double CalculateFactorial(int num)
        {
            double factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}