namespace _2._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //a e i o u
            GetVowelsCount();

        }

        static void GetVowelsCount()
        {
            int VowelsCount = 0;
            string input = Console.ReadLine();
            string lowerInput = input.ToLower();
            for (int j = 0; j < input.Length; j++)
            {
                char currennt = lowerInput[j];
                if (currennt == 'a'|| currennt == 'e'|| currennt == 'i' || currennt == 'o' || currennt == 'u')
                {
                    VowelsCount++;
                }
            }
            Console.WriteLine(VowelsCount);
        }

    }
}