using System;
namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {


            double neededMnoey = double.Parse(Console.ReadLine());
            double ownedMoney = double.Parse(Console.ReadLine());

            int daysCounter = 0;
            int spendingCounter = 0;

            while (ownedMoney < neededMnoey && spendingCounter < 5)
            {
                string command = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                daysCounter++;
                if (command == "spend")
                {
                    spendingCounter++;
                    ownedMoney -= money;
                    if (ownedMoney < 0)
                    {
                        ownedMoney = 0;
                    }

                }
                else if (command == "save")
                {
                    spendingCounter = 0;
                    ownedMoney += money;
                }
            }
            if (spendingCounter == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(daysCounter);
            }
            if (ownedMoney >= neededMnoey)
            {
                Console.WriteLine($" You saved the money for {daysCounter} days.");
            }

        }
    }
}