namespace _02._Sets_of_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] lenght = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int n = lenght[0];
            int m = lenght[1];

            HashSet<int> uniqueN = new();

            for (int i = 0; i < n; i++)
            {
                uniqueN.Add(int.Parse(Console.ReadLine()));
            }

            HashSet<int> uniqueM = new();

            for (int j = 0; j < m; j++)
            {
                uniqueM.Add(int.Parse(Console.ReadLine()));
            }

            HashSet<int> checkedSet = new();


            foreach (int num in uniqueN)
            {
                if (uniqueM.Contains(num))
                {
                    checkedSet.Add(num);
                }
            }

            foreach (int checkedNum in checkedSet)
            {
                Console.Write($"{checkedNum} ");
            }
        }
    }
}