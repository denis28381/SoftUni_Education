using System;
namespace _09._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double saber = double.Parse(Console.ReadLine());
            double robe = double.Parse(Console.ReadLine());
            double belt = double.Parse(Console.ReadLine());

            double saberT = saber * (Math.Ceiling(students * 1.1));
            int freeb = students / 6;
            double beltT = belt * (students - freeb);
            double robeT = robe * students;

            double total = saberT + beltT + robeT;

            if (total <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {total:F2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {total - money:F2}lv more.");
            }

        }
    }
}