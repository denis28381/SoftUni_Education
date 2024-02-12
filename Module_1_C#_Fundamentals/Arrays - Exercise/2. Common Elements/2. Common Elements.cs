namespace _2._Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            string[] firstArr = input1.Split(); // Split the input string by whitespace into an array

            string input2 = Console.ReadLine();
            string[] secondArr = input2.Split(); // Split the input string by whitespace into an array

            // Find common elements between firstArr and secondArr
            List<string> commonElements = secondArr.Intersect(firstArr).ToList();

            foreach (string element in commonElements)
            {
                Console.Write($"{element} ");
            }

        }
    }
}