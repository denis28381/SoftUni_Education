using System;
using System.Collections.Generic;
using System.Linq;
namespace _02.Coffee_Lover
{ 
    class Program
    {
        static void Main()
        {
            List<string> coffees = Console.ReadLine().Split().ToList();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();

                switch (command[0])
                {
                    case "Include":
                        string coffeeToAdd = command[1];
                        coffees.Add(coffeeToAdd);
                        break;

                    case "Remove":
                        int countToRemove = int.Parse(command[2]);
                        if (command[1] == "first" && countToRemove <= coffees.Count)
                        {
                            coffees.RemoveRange(0, countToRemove);
                        }
                        else if (command[1] == "last" && countToRemove <= coffees.Count)
                        {
                            int startIndex = coffees.Count - countToRemove;
                            coffees.RemoveRange(startIndex, countToRemove);
                        }
                        break;

                    case "Prefer":
                        int index1 = int.Parse(command[1]);
                        int index2 = int.Parse(command[2]);
                        if (IsIndexValid(index1, coffees) && IsIndexValid(index2, coffees))
                        {
                            string temp = coffees[index1];
                            coffees[index1] = coffees[index2];
                            coffees[index2] = temp;
                        }
                        break;

                    case "Reverse":
                        coffees.Reverse();
                        break;
                }
            }

            Console.WriteLine("Coffees:");
            Console.WriteLine(string.Join(" ", coffees));
        }

        static bool IsIndexValid(int index, List<string> list)
        {
            return index >= 0 && index < list.Count;
        }
    }
}