using System;
namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nPeople = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();

            double price = 0;

            switch (type)
            {
                case "Students":
                    switch (day)
                    {
                        case "Friday":
                            price = 8.45;
                            break;

                        case "Saturday":
                            price = 9.80;
                            break;

                        case "Sunday":
                            price = 10.46;
                            break;
                    }

                    price *= nPeople;

                    if (nPeople >= 30)
                    {
                        price = price - price * 0.15;
                    }

                    break;

                case "Business":
                    switch (day)
                    {
                        case "Friday":
                            price = 10.90;
                            break;

                        case "Saturday":
                            price = 15.60;
                            break;

                        case "Sunday":
                            price = 16;
                            break;
                    }

                    if (nPeople >= 100)
                    {
                        nPeople -= 10;
                    }

                    price *= nPeople;

                    break;

                case "Regular":
                    switch (day)
                    {
                        case "Friday":
                            price = 15;
                            break;

                        case "Saturday":
                            price = 20;
                            break;

                        case "Sunday":
                            price = 22.50;
                            break;
                    }

                    price *= nPeople;

                    if (nPeople >= 10 && nPeople <= 20)
                    {
                        price = price - price * 0.05;
                    }

                    break;
            }


            Console.WriteLine($"Total price: {price:f2}");

        }
    }
}