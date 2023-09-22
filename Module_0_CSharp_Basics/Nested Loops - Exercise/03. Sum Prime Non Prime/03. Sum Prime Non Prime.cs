using System;
namespace _03._Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {


            string input = Console.ReadLine();
            bool prime = true;

            int sumPrime = 0;
            int sumNonPrime = 0;

            while (input != "stop")
            {
                int inputToInt = int.Parse(input);

                if (inputToInt < 0)
                {
                    Console.WriteLine("Number is negative.");
                    goto loop;
                }

                for (int i = 2; i <= Math.Sqrt(inputToInt); i++)
                {
                    if (inputToInt % i == 0)
                    {

                        prime = false;
                        break;
                    }
                }

                if (prime)
                {
                    sumPrime += inputToInt;
                }
                else
                {
                    sumNonPrime += inputToInt;
                }
                prime = true;
            loop:
                input = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrime}");
        }
    }
}