﻿using System;
namespace _04._Even_Powers_of_2
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());

            for (int i = 0; i <= a; i += 2)
            {
                Console.WriteLine(Math.Pow(2, i));
            }

        }
    }
}