namespace _06._Building
{
    class Program
    {
        static void Main(string[] args)
        {

            int floors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());

            int f = floors;
            for (int a = 1; f >= a; f--)
            {
                for (int b = 0; b < rooms; b++)
                {

                    if (floors == f)
                    {
                        Console.Write($"L{f}{b} ");
                    }
                    else if (f % 2 == 0)
                    {
                        Console.Write($"O{f}{b} ");
                    }
                    else
                    {
                        Console.Write($"A{f}{b} ");
                    }

                    if (b == rooms - 1)
                    {
                        Console.Write("\n");
                    }
                }
            }

        }
    }
}