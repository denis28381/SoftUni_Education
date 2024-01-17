namespace _02._Basic_Queue_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firtLine = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int[] secondLine = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            Queue<int> intigerQueue = new Queue<int>(secondLine);

            for (int i = 0; i < firtLine[1]; i++)
            {
                intigerQueue.Dequeue();
            }

            if (!intigerQueue.Any())
            {
                Console.WriteLine(0);
            }
            else if (intigerQueue.Contains(firtLine[2]))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(intigerQueue.Min());
            }

        }
    }
}