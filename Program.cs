using System;
namespace CabInoviceGenarator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my InvoiceGenerator Program");
            InvoiceGenerator inoviceGenarator = new InvoiceGenerator(RideType.NORMAL);
            double fare = inoviceGenarator.CalculateFare(2.0, 5);
            Console.WriteLine(fare);
        }
    }
}