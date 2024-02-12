using System;
namespace _10._Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int lGC = int.Parse(Console.ReadLine());
            double hP = double.Parse(Console.ReadLine());
            double mP = double.Parse(Console.ReadLine());
            double kP = double.Parse(Console.ReadLine());
            double dP = double.Parse(Console.ReadLine());

            double totE = 0;



            totE = hP * (lGC / 2);
            totE += mP * (lGC / 3);
            totE += kP * (lGC / 6);
            totE += dP * (lGC / 12);


            Console.WriteLine($"Rage expenses: {totE:F2} lv.");
        }
    }
}