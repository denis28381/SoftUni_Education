namespace _9._Kamino_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int[] bestDNA = new int[length];
            int bestLength = 0;
            int bestStartIndex = 0;
            int bestSum = 0;
            int sequenceIndex = 0;
            int currentSequenceIndex = 0;

            while (input != "Clone them!")
            {
                int[] currentDNA = Array.ConvertAll(input.Split('!', StringSplitOptions.RemoveEmptyEntries), int.Parse);
                int currentLength = 0;
                int currentStartIndex = 0;
                int currentSum = 0;

                for (int i = 0; i < length; i++)
                {
                    if (currentDNA[i] == 1)
                    {
                        currentLength++;
                        currentSum++;
                        if (currentLength == 1)
                        {
                            currentStartIndex = i;
                        }
                    }
                    else
                    {
                        currentLength = 0;
                        currentSum = 0;
                    }

                    if (currentLength > bestLength || (currentLength == bestLength && (currentStartIndex < bestStartIndex || (currentStartIndex == bestStartIndex && currentSum > bestSum))))
                    {
                        bestLength = currentLength;
                        bestStartIndex = currentStartIndex;
                        bestSum = currentSum;
                        bestDNA = currentDNA;
                        sequenceIndex = currentSequenceIndex;
                    }
                }

                currentSequenceIndex++;
                input = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {sequenceIndex + 1} with sum: {bestSum}.");
            Console.WriteLine(string.Join(" ", bestDNA));
        }
    }
}