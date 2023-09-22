using System;
namespace _10._Invalid_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n == 0 || n >= 100 & n <= 200)
            {
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
    }
}