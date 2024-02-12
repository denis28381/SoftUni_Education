namespace _04._Even_Times
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            // HashSet<int> numbersSet = new();
            //
            // int even = 0;
            //
            // for (int a = 0; a < n; a++)
            // {
            //     int number = int.Parse(Console.ReadLine());
            //
            //     if (numbersSet.Contains(number))
            //     {
            //         even = number;
            //     }
            //     else
            //     {
            //         numbersSet.Add(number);
            //     }
            // }
            //
            // Console.WriteLine(even);

            Dictionary<int, bool> numbers = new();

            for (int i = 0; i < n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                if (numbers.ContainsKey(currentNum))
                {
                    numbers[currentNum] = !numbers[currentNum];
                }
                else
                {
                    numbers.Add(currentNum, false);
                }
            }

            foreach (int number in numbers.Keys)
            {
                if (numbers[number])
                {
                    Console.WriteLine(number);
                }
            }

        }
    }
}