namespace _08._Pet_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dog = int.Parse(Console.ReadLine());
            int cat = int.Parse(Console.ReadLine());
            double dogpr = (2.50 * dog);
            double catpr = (4 * cat);
            double total = dogpr + catpr;

            Console.WriteLine(total + " lv.");
        }
    }
}