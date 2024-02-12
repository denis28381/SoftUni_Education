namespace _6._Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            PrintMiddleCharacter(input);
        }

        static void PrintMiddleCharacter(string input)
        {
            int length = input.Length;

            if (length % 2 == 0)
            {
                int middle = length / 2 - 1;
                Console.Write(input[middle]);
                Console.Write(input[middle + 1]);
            }
            else
            {
                int middle = length / 2;
                Console.Write(input[middle]);
            }
        }
    }
}