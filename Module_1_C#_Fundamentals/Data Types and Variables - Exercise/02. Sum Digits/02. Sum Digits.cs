namespace _02._Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int total = 0;

            for (int i = 0; i < a.Length; i++)
            {
                total += a[i] - 48;
            }
            Console.WriteLine(total);
        }
    }
}