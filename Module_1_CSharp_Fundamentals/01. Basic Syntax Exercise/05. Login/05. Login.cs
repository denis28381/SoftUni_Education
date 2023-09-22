using System;
namespace _05._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string user = Console.ReadLine();
            string password = "";
            string correctPassword = "";

            for (int i = user.Length - 1; i >= 0; i--)
            {
                correctPassword += user[i];
            }

            int c = 0;

            while (c < 4)
            {
                password = Console.ReadLine();
                c++;

                if (password == correctPassword)
                {
                    Console.WriteLine($"User {user} logged in.");
                    break;
                }
                else if (c == 4)
                {
                    Console.WriteLine($"User {user} blocked!");
                }
                else if (password != correctPassword)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
            }

        }
    }
}