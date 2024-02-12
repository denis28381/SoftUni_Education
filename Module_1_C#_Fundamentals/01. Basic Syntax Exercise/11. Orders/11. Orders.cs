using System;
namespace _11._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numberOfOrders = int.Parse(Console.ReadLine());
            double pricePerCapsule = 0;
            int daysInMonth = 0;
            double capsulesCount = 0;
            double price = 0;
            double totalPrice = 0;


            for (int i = 0; i < numberOfOrders; i++)
            {
                pricePerCapsule = double.Parse(Console.ReadLine());
                daysInMonth = int.Parse(Console.ReadLine());
                capsulesCount = int.Parse(Console.ReadLine());

                price = ((daysInMonth * capsulesCount) * pricePerCapsule);

                Console.WriteLine($"The price for the coffee is: ${price:F2}");

                totalPrice += price;

            }
            Console.WriteLine($"Total: ${totalPrice:F2}");
        }
    }
}