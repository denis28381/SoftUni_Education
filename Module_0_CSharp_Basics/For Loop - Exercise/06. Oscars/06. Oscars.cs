using System;
namespace _06._Oscars
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = Console.ReadLine();
            double points = double.Parse(Console.ReadLine());
            int judjes = int.Parse(Console.ReadLine());


            for (int i = 1; i <= judjes; i++)
            {
                string jName = Console.ReadLine();
                int jNameLenght = 0;
                for (int b = 0; b < jName.Length; b++) { jNameLenght++; }

                double jPoints = double.Parse(Console.ReadLine());

                points = points + ((jNameLenght * jPoints) / 2);

                if (points >= 1250.5)
                {
                    Console.WriteLine($"Congratulations, {name} got a nominee for leading role with {points:f1}!");
                    return;
                }
            }
            double need = 1250.5 - points;
            Console.WriteLine($"Sorry, {name} you need {need:f1} more!");
        }
    }
}