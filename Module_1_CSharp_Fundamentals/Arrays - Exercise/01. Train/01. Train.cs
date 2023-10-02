namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int total = 0;

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                
            }
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{arr[j]} ");
                total += arr[j];
            }
            Console.WriteLine($"\n{total}");
        }
    }
}