namespace _08._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double bigest = 0;
            string bigestName = "";
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double r = double.Parse(Console.ReadLine());
                int h = int.Parse(Console.ReadLine());

                double vol = Math.PI * Math.Pow(r, 2) * h;

                if (vol > bigest)
                {
                    bigest = vol;
                    bigestName = name;
                }
            }
            Console.WriteLine(bigestName);
        }
    }
}