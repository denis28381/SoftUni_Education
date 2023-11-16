namespace _9._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                    break;

                int number = int.Parse(input);
                bool isPalindrome = IsPalindrome(number);

                Console.WriteLine(isPalindrome ? "true" : "false");
            }
        }

        static bool IsPalindrome(int number)
        {
            string numberStr = number.ToString();
            int left = 0;
            int right = numberStr.Length - 1;

            while (left < right)
            {
                if (numberStr[left] != numberStr[right])
                {
                    return false;
                }
                left++;
                right--;
            }

            return true;
        }
    }
}