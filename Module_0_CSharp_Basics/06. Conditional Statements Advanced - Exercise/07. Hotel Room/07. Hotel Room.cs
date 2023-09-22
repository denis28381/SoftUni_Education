using System;
namespace _07._Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {

            string month = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());

            double dicount = 0;
            double dicountAp = 0;
            double studio = 0;
            double apart = 0;

            if (a > 14)
            {
                dicountAp = 0.10;
            }
            switch (month)
            {
                case "May":
                case "October":
                    studio = 50;
                    apart = 65;
                    if (a > 7 && a <= 14)
                    {
                        dicount = 0.05;
                    }
                    else if (a > 14)
                    {
                        dicount = 0.30;
                    }
                    break;
                case "June":
                case "September":
                    studio = 75.20;
                    apart = 68.70;
                    if (a > 14)
                    {
                        dicount = 0.20;
                    }
                    break;
                case "July":
                case "August":
                    studio = 76;
                    apart = 77;
                    break;
            }

            studio = studio * a;
            apart = apart * a;

            if (dicount != 0)
            {
                studio = studio - studio * dicount;
            }

            if (dicountAp != 0)
            {
                apart = apart - apart * dicountAp;
            }

            Console.WriteLine($"Apartment: {apart:f2} lv.");
            Console.WriteLine($"Studio: {studio:f2} lv.");

        }
    }
}