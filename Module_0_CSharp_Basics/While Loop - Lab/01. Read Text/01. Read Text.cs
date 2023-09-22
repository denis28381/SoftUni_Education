using System;
namespace _01._Read_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            while (a)
            {
                string s = Console.ReadLine();
                if (s != "Stop")
                {
                    Console.WriteLine(s);
                }
                else
                {
                    a = false;
                }
            }
        }
    }
}