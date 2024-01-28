namespace _05._Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> delivery = new Stack<int>(
                Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray());

            int rackCapacity = int.Parse(Console.ReadLine());

            int racksUsed = 0;
            int currentRackCapacity = rackCapacity;

            if (delivery.Any())
            {
                racksUsed++;
            }

            while (delivery.Any())
            {
                if (delivery.Peek() <= currentRackCapacity)
                {
                    currentRackCapacity -= delivery.Pop();
                }
                else
                {
                    racksUsed++;
                    currentRackCapacity = racksUsed;
                }
            }

            Console.WriteLine(racksUsed);
        }
    }
}