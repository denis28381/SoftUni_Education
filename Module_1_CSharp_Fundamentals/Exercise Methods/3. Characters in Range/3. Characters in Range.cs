using System.Formats.Asn1;

namespace _3._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetCharRange();
        }

        static void GetCharRange()
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());

            bool cont = true;
            while (cont)
            {
                if (a != b -1)
                {
                    a++;
                    Console.Write(a + " ");
                    
                }
                else
                {
                    cont = false;
                }
            }
            

        }
    }
}