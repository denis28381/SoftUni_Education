using System.Text;

namespace _4._Caesar_Cipher
{
    internal class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();

            StringBuilder cipherBulder = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                char original = text[i];
                cipherBulder.Append((char)(original + 3));

            }
            Console.WriteLine(cipherBulder);

        }
    }
}