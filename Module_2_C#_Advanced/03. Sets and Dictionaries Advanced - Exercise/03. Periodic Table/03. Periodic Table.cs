using System.Xml.Linq;

namespace _03._Periodic_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            SortedSet<string> elementSortedSet = new();

            for (int i = 0; i < n; i++)
            {
                string[] compounds = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                foreach (string element in compounds)
                {
                    elementSortedSet.Add(element);
                }
            }

            foreach (string sortedElement in elementSortedSet)
            {
                Console.Write($"{sortedElement} ");
            }

            
        }
    }
}