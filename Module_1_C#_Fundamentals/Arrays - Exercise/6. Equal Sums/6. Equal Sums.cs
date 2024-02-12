namespace _6._Equal_Sums
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

            for (int i = 0; i < array.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;

                // Calculate the sum of elements to the left
                for (int j = 0; j < i; j++)
                {
                    leftSum += array[j];
                }

                // Calculate the sum of elements to the right
                for (int j = i + 1; j < array.Length; j++)
                {
                    rightSum += array[j];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return; // Exit the program if a match is found
                }
            }

            // If no element satisfies the condition
            Console.WriteLine("no");
        }
    }
}