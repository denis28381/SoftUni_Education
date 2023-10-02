namespace _5._Top_Integers
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
                bool isTopInteger = true;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] <= array[j])
                    {
                        isTopInteger = false;
                        break;
                    }
                }

                if (isTopInteger)
                {
                    Console.Write(array[i] + " ");
                }
            }
        }
    }
}