using System.Threading.Channels;

namespace _4._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pass = Console.ReadLine();
            

            if (checkLength(pass) == true & checkLettersDigits(pass) == true & checkTwoDigits(pass) == true)
            {
                Console.WriteLine("Password is valid");
            }

        }

        static bool checkLength(string password)
        {
            if (password.Length < 6 || 10 < password.Length)
            {
                Console.WriteLine("Password must be between 6 and 10 characters ");
                return false;
            }
            else
            {
                return true;
            }
        }

        static bool checkLettersDigits(string password)
        {
            foreach (char c in password)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                    return false;
                }
            }
            return true;
        }

        static bool checkTwoDigits(string password)
        {
            int digitCount = 0;

            foreach (char c in password)
            {
                if (char.IsDigit(c))
                {
                    digitCount++;
                    if (digitCount >= 2)
                    {
                        return true;
                    }
                }
            }

            Console.WriteLine("Password must have at least 2 digits");
            return false;
        }
    }
}