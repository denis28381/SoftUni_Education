using System;
namespace _05._Salary
{
    class Program
    {
        static void Main(string[] args)
        {

            int tabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            int Facebook = 150;
            int Instagram = 100;
            int Reddit = 50;
            int fine = 0;

            for (int i = 1; i <= tabs; i++)
            {
                string currentTab = Console.ReadLine();

                switch (currentTab)
                {
                    case "Facebook":
                        fine += Facebook;
                        break;
                    case "Instagram":
                        fine += Instagram;
                        break;
                    case "Reddit":
                        fine += Reddit;
                        break;
                }

            }
            salary -= fine;

            if (salary <= 0)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine(salary);
            }
        }
    }
}