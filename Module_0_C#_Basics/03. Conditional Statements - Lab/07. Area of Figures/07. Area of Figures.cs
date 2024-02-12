using System;
namespace _07._Area_of_Figures
{
    class Program
    {
        public void square()
        {
            double a = double.Parse(Console.ReadLine());
            a *= a;
            Console.WriteLine(a);
        }

        public void rectangle()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = a * b;
            Console.WriteLine(c);
        }

        public void circle()
        {
            double a = double.Parse(Console.ReadLine());
            double c = Math.PI * a * a;
            Console.WriteLine(c);
        }

        public void triangle()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = (a * b) / 2;
            Console.WriteLine(c);

        }
        static void Main(string[] args)
        {
            Program p = new Program();
            string type = Console.ReadLine();

            if (type == "square")
            {
                p.square();
            }

            if (type == "rectangle")
            {
                p.rectangle();
            }

            if (type == "circle")
            {
                p.circle();
            }

            if (type == "triangle")
            {
                p.triangle();
            }
        }
    }
}