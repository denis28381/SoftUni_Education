using System.Text;

namespace _7._String_Explosion
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            string result = ProcessExplosions(input);
            Console.WriteLine(result);
        }

        private static string ProcessExplosions(string input)
        {
            StringBuilder reStringBuilder = new StringBuilder();

            int strenght = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '>')
                {
                    strenght += int.Parse(input[i + 1].ToString());
                    reStringBuilder.Append(input[i]);
                }
                else if (strenght == 0)
                {
                    reStringBuilder.Append(input[i]);
                }
                else
                {
                    strenght--;
                }
            }

            return reStringBuilder.ToString();
            
        }
    }
}