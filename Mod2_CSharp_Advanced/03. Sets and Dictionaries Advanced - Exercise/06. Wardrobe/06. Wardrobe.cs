namespace _06._Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> wardrobe = new();

            //Fill the Wardrobe
            FillWardrobe(lines, wardrobe);

            //Search for item
            Search(wardrobe);
        }

        private static void Search(Dictionary<string, Dictionary<string, int>> wardrobe)
        {
            string[] searchItem = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");
                foreach (var item in color.Value)
                {
                    Console.Write($"* {item.Key} - {item.Value}");

                    if (color.Key == searchItem[0] && item.Key == searchItem[1])
                    {
                        Console.Write(" (found!)");
                    }

                    Console.WriteLine();
                }
            }
        }

        private static void FillWardrobe(int lines, Dictionary<string, Dictionary<string, int>> wardrobe)
        {
            for (int i = 0; i < lines; i++)
            {
                string[] newEntry = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                string color = newEntry[0];
                string[] newClothes = newEntry[1]
                    .Split(",", StringSplitOptions.RemoveEmptyEntries);

                AddColorWardrobe(wardrobe, color);

                AddChloathesColor(newClothes, wardrobe, color);
            }
        }

        private static void AddChloathesColor(string[] newClothes, Dictionary<string, Dictionary<string, int>> wardrobe, string color)
        {
            foreach (string item in newClothes)
            {
                if (!wardrobe[color].ContainsKey(item))
                {
                    wardrobe[color].Add(item, 1);
                }
                else
                {
                    wardrobe[color][item]++;
                }
            }
        }

        private static void AddColorWardrobe(Dictionary<string, Dictionary<string, int>> wardrobe, string color)
        {
            if (!wardrobe.ContainsKey(color))
            {
                wardrobe.Add(color, new Dictionary<string, int>());
            }
        }
    }
}