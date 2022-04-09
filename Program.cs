using System;

namespace CabInvoiceGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Cab Invoice Gernerator");

            InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.PREMIUM);

            double fare = invoiceGenerator.CalculateFare(2.0, 5);

            Console.WriteLine(fare);
        }
    }
}