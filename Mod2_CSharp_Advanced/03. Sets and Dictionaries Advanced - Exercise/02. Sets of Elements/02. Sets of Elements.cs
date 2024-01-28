namespace _02._Sets_of_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            HashSet<int> uniqueN = new();

            for (int i = 0; i < n; i++)
            {
                uniqueN.Add(int.Parse(Console.ReadLine()));
            }

            for (int j = 0; j < m; j++)
            {
                uniqueN.Add(int.Parse(Console.ReadLine()));
            }


            foreach (int num in uniqueN)
            {
                Console.WriteLine(num);
            }
        }
    }
}