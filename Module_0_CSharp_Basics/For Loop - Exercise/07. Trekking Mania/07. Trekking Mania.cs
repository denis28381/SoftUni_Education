using System;
namespace _07._Trekking_Mania
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            double musala = 0; //< 5
            double monblan = 0; //6-12
            double kilimandjaro = 0; //13-25
            double k2 = 0; //26-40
            double everest = 0; //>= 41
            int ppl = 0;

            for (int i = 0; i < n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());

                ppl += currentNum;

                if (currentNum <= 5)
                {
                    musala += currentNum;

                }
                else if (currentNum >= 6 && currentNum <= 12)
                {
                    monblan += currentNum;

                }
                else if (currentNum >= 13 && currentNum <= 25)
                {
                    kilimandjaro += currentNum;

                }
                else if (currentNum >= 26 && currentNum <= 40)
                {
                    k2 += currentNum;

                }
                else if (currentNum >= 41)
                {
                    everest += currentNum;

                }
            }
            musala = musala / ppl * 100;
            monblan = monblan / ppl * 100;
            kilimandjaro = kilimandjaro / ppl * 100;
            k2 = k2 / ppl * 100;
            everest = everest / ppl * 100;

            Console.WriteLine($"{musala:f2}%");
            Console.WriteLine($"{monblan:f2}%");
            Console.WriteLine($"{kilimandjaro:f2}%");
            Console.WriteLine($"{k2:f2}%");
            Console.WriteLine($"{everest:f2}%");
        }
    }
}