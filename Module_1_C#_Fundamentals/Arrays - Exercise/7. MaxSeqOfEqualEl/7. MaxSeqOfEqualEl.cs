namespace _7._MaxSeqOfEqualEl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputArray = Console.ReadLine().Split();
            int[] array = new int[inputArray.Length];

            for (int i = 0; i < inputArray.Length; i++)
            {
                array[i] = int.Parse(inputArray[i]);
            }

            int maxLength = 1;
            int currentLength = 1;
            int startIndex = 0;
            int currentStartIndex = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == array[i - 1])
                {
                    currentLength++;
                }
                else
                {
                    currentLength = 1;
                    currentStartIndex = i;
                }

                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                    startIndex = currentStartIndex;
                }
            }

            for (int i = startIndex; i < startIndex + maxLength; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}