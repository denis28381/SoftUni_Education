using System.Collections.Generic;
using System;
using System.Linq;
namespace _1._Train

{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> train = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int maxCapacity = int.Parse(Console.ReadLine());

            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] arguments = input.Split();

                if (arguments[0] == "Add")
                {
                    int passangers = int.Parse(arguments[1]);
                    train.Add(passangers);
                }
                else
                {
                    int newPassangers = int.Parse(arguments[0]);

                    for (int i = 0; i < train.Count; i++)
                    {
                        if (train[i] + newPassangers <= maxCapacity)
                        {
                            train[i] += newPassangers;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", train));
        }
    }
}