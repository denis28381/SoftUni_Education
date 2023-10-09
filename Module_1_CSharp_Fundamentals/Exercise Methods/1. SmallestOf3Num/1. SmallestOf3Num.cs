namespace _1._SmallestOf3Num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            GetSmallest();

        }

        static void GetSmallest()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int smallest = Int32.MaxValue;

            if (a < smallest)
            {
                smallest = a;
            }

            if (b < smallest)
            {
                smallest = b;
            }

            if (c < smallest)
            {
                smallest = c;
            }

            Console.WriteLine(smallest);
        }
    }
}