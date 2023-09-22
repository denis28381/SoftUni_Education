using System;
namespace _09._Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {

            int days = int.Parse(Console.ReadLine());
            days--;
            string type = Console.ReadLine();
            string grade = Console.ReadLine();


            double roomForOnePerson = 18;
            double apartment = 25;
            double presidentApartment = 35;

            double dicountApartment = 0;
            double dicountPresidentApartment = 0;

            double total = 0;

            while (type == "apartment" || type == "president apartment")
            {

                if (days < 10)
                {
                    dicountApartment = 0.30;
                    dicountPresidentApartment = 0.10;
                }
                else if (days >= 10 && days <= 15)
                {
                    dicountApartment = 0.35;
                    dicountPresidentApartment = 0.15;
                }
                else if (days > 15)
                {
                    dicountApartment = 0.50;
                    dicountPresidentApartment = 0.20;
                }

                switch (type)
                {
                    case "apartment":
                        total = apartment * days;
                        total -= total * dicountApartment;
                        break;
                    case "president apartment":
                        total = presidentApartment * days;
                        total -= total * dicountPresidentApartment;
                        break;
                }


                if (grade == "positive")
                {
                    total = total + total * 0.25;
                }
                else if (grade == "negative")
                {
                    total = total - total * 0.10;
                }

                Console.WriteLine($"{total:f2}");
                return;
            }

            total = roomForOnePerson * days;

            if (grade == "positive")
            {
                total = total + total * 0.25;
            }
            else if (grade == "negative")
            {
                total = total - total * 0.10;
            }

            Console.WriteLine($"{total:f2}");

        }
    }
}