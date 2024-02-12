using System;
namespace _04._Vacation_Books_List
{
    class Program
    {
        static void Main(string[] args)
        {
            int TotalPages = int.Parse(Console.ReadLine());
            int PagesPerH = int.Parse(Console.ReadLine());
            int Days = int.Parse(Console.ReadLine());

            int BookTime = TotalPages / PagesPerH;
            int TimePerDay = BookTime / Days;

            Console.WriteLine(TimePerDay);
        }
    }
}