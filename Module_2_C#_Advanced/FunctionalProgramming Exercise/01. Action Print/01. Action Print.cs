﻿namespace _01._Action_Print
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();


                Action<string> print = s => Console.WriteLine(s);

                Array.ForEach(input, print);
        }
    }
}