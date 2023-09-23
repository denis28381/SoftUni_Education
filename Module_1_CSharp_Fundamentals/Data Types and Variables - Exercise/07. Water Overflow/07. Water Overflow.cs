namespace _07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = 255;
            int total = 0;

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());

                if (input + total > max)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    total += input;
                }
            }
            Console.WriteLine(total);
        }
    }
}