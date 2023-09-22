using System;
namespace _09._Fruit_or_Vegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            string v = Console.ReadLine();

            if (v == "banana" || v == "apple" || v == "kiwi" || v == "cherry" || v == "lemon" || v == "grapes")
            {
                Console.WriteLine("fruit");
            }
            else if (v == "tomato" || v == "cucumber" || v == "pepper" || v == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}