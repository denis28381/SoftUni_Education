namespace _07._Projects_Creation
{
    class Program
    {
        static void Main(string[] args)
        {
            int b = 3;
            String name = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());

            double c = a * 3;

            Console.WriteLine("The architect " + name + " will need " + c + " hours to complete " + a + " project/s.");

        }
    }
}