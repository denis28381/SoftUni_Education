using System;
namespace _01._Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            string book = Console.ReadLine();

            string check = Console.ReadLine();

            while (check != "No More Books")
            {

                if (check == book)
                {
                    Console.WriteLine($"You checked {n} books and found it.");
                    return;
                }
                n++;
                check = Console.ReadLine();
            }
            Console.WriteLine("The book you search is not here!");
            Console.WriteLine($"You checked {n} books.");


        }
    }
}