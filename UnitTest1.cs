using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CabInvoiceGeneratorUnitTest
{
    [TestClass]
    public class UnitTestCab
    {
        public object RideType { get; private set; }

        [TestMethod]
        public void GivenDistanceAndTimeShouldReturnTotalFare()
        {
            InvoiceGenerator invoice = new InvoiceGenerator(RideType.NORMAL);
            double distance = 2.0;
            int time = 5;
            double expected = 25;

            double fare = invoice.CalculateFare(distance, time);

            Assert.AreEqual(expected, fare);
        }

        [TestMethod]
        public void GivenMultipleRideShouldReturnInvoiceSummary()
        {
            InvoiceGenerator invoice = new InvoiceGenerator(RideType.NORMAL);
            Ride[] rides = { new Ride(2.0, 5), new Ride(0.1, 1) };

            InvoiceSummary invoiceSummary = invoice.CalculateFare(rides);
            InvoiceSummary Expected = new InvoiceSummary(2, 27.0);

            Assert.AreEqual(Expected, invoiceSummary);
        }
    }

    internal class Ride
    {
        private double v1;
        private int v2;

        public Ride(double v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }
    }

    internal class InvoiceGenerator
    {
        public InvoiceGenerator(object nORMAL)
        {
            NORMAL = nORMAL;
        }

        public object NORMAL { get; }

        internal double CalculateFare(double distance, int time)
        {
            throw new NotImplementedException();
        }

        internal InvoiceSummary CalculateFare(Ride[] rides)
        {
            throw new NotImplementedException();
        }
    }
}