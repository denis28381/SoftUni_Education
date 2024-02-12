using System;
namespace _02._Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string pass = Console.ReadLine();
            bool a = true;

            while (a)
            {
                string inp = Console.ReadLine();
                if (inp == pass)
                {
                    Console.WriteLine($"Welcome {name}!");
                    return;
                }
            }
        }
    }
}