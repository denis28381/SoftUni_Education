using System;
namespace _05._Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double coinIn = double.Parse(Console.ReadLine());
            int count = 0;


            while (coinIn > 0)
            {

                if (coinIn - 2 >= 0)
                {
                    coinIn -= 2.00;
                    count++;
                    coinIn = Math.Round(coinIn, 2);


                }
                else if (coinIn - 1 >= 0)
                {
                    coinIn -= 1.00;
                    count++;
                    coinIn = Math.Round(coinIn, 2);

                }
                else if (coinIn - 0.50 >= 0)
                {
                    coinIn -= 0.50;
                    count++;
                    coinIn = Math.Round(coinIn, 2);
                }
                else if (coinIn - 0.20 >= 0)
                {
                    coinIn -= 0.20;
                    count++;
                    coinIn = Math.Round(coinIn, 2);
                }
                else if (coinIn - 0.10 >= 0)
                {
                    coinIn -= 0.10;
                    count++;
                    coinIn = Math.Round(coinIn, 2);
                }
                else if (coinIn - 0.05 >= 0)
                {
                    coinIn -= 0.05;
                    count++;
                    coinIn = Math.Round(coinIn, 2);
                }
                else if (coinIn - 0.02 >= 0)
                {
                    coinIn -= 0.02;
                    count++;
                    coinIn = Math.Round(coinIn, 2);
                }
                else if (coinIn - 0.01 >= 0)
                {
                    coinIn -= 0.01;
                    count++;
                    coinIn = Math.Round(coinIn, 2);
                }


            }

            Console.WriteLine(count);

        }
    }
}