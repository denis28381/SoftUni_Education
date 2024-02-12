namespace _09._Yard_Greening
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 7.61;
            double disc = 0.18;

            double b = double.Parse(Console.ReadLine());


            double total = (b * a) - ((b * a) * disc);

            Console.WriteLine("The final price is: " + total + " lv.");
            disc = (b * a) * disc;
            Console.WriteLine("The discount is: " + disc + " lv.");
        }
    }
}