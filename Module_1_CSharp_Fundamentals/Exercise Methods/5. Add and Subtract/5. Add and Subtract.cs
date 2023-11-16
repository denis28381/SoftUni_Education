namespace _5._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int sumResult = CalculateSum(num1, num2);
            int finalResult = SubtractFromSum(sumResult, num3);

            Console.WriteLine(finalResult);
        }
        static int CalculateSum(int a, int b)
        {
            return a + b;
        }

        static int SubtractFromSum(int sum, int c)
        {
            return sum - c;
        }
    }
}