namespace _3._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isFirstSelected = true;
            string[] firstArr = new string[n];
            string[] secondArr = new string[n];

            for (int i = 0; i < n; i++)
            {
                string numbers = Console.ReadLine();

                string[] numbersArray = numbers.Split();

                if (isFirstSelected)
                {
                    firstArr[i] = numbersArray[0];
                    secondArr[i] = numbersArray[1];
                }
                else
                {
                    firstArr[i] = numbersArray[1];
                    secondArr[i] = numbersArray[0];
                }

                isFirstSelected = !isFirstSelected;
                
            }
             
            Console.WriteLine(string.Join(" ", firstArr));
            Console.WriteLine(string.Join(" ", secondArr));

        }
    }
}