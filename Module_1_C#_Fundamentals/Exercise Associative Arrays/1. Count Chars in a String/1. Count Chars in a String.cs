namespace _1._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main()
        {
            string input =Console.ReadLine();
            Dictionary<char, int> charOcccurrences = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                char character = input[i];

                if (character == ' ')
                {
                    continue;
                }

                if (!charOcccurrences.ContainsKey(character))
                {
                    charOcccurrences.Add(character, 0);
                }

                charOcccurrences[character]++;
            }

            foreach (var occurrence in charOcccurrences)
            {
                char character = occurrence.Key;
                int count = occurrence.Value;
                Console.WriteLine($"{character} -> {count}");
            }
        }
    }
}