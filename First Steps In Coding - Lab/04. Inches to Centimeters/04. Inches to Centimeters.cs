namespace _04._Inches_to_Centimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            double i = double.Parse(Console.ReadLine());
            double itocm = 2.54;
            double cm = (i * itocm);

            Console.WriteLine(cm);
        }
    }
}