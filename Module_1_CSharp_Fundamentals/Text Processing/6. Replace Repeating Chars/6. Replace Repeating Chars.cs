using System.Text;

namespace _6._Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            StringBuilder resultBuilder = new StringBuilder();
            resultBuilder.Append(input[0]);

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] != input[i - 1])
                {
                    resultBuilder.Append(input[i]);
                }
            }

            Console.WriteLine(resultBuilder);
        }
    }
}