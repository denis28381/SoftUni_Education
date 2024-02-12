using System;
namespace _06._OpBetweenNum
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            string op = Console.ReadLine();
            double total = 0;

            while (b != 0)
            {
                if (op == "/" || op == "%")
                {
                    switch (op)
                    {
                        case "/":
                            double ad = a;
                            double bd = b;
                            total = ad / bd;
                            Console.WriteLine($"{a} / {b} = {total:f2}");
                            break;
                        case "%":
                            total = a % b;
                            Console.WriteLine($"{a} % {b} = {total}");
                            break;
                    }
                }
                else
                {
                    string ab = "";

                    switch (op)
                    {

                        case "+":
                            total = a + b;
                            if (total % 2 == 0) { ab = "even"; }
                            else { ab = "odd"; }
                            Console.WriteLine($"{a} + {b} = {total} - {ab}");
                            break;
                        case "-":
                            total = a - b;
                            if (total % 2 == 0) { ab = "even"; }
                            else { ab = "odd"; }
                            Console.WriteLine($"{a} - {b} = {total} - {ab}");
                            break;
                        case "*":
                            total = a * b;
                            if (total % 2 == 0) { ab = "even"; }
                            else { ab = "odd"; }
                            Console.WriteLine($"{a} * {b} = {total} - {ab}");
                            break;

                    }
                }
                return;
            }
            Console.WriteLine($"Cannot divide {a} by zero");

        }
    }
}