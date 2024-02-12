namespace _01._Unique_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            HashSet<string> uniqueUserName = new();

            for (int i = 0; i < lines; i++)
            {
                uniqueUserName.Add(Console.ReadLine());
            }

            foreach (string userName in uniqueUserName)
            {
                Console.WriteLine(userName);
            }
        }
    }
}