using Microsoft.VisualStudio.TestTools.UnitTesting;
using CabInvoice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoice.Tests
{
    [TestClass()]
    public class InvoiceGeneratorTests
    {
        [TestMethod()]
        public void CalculateFareTest()
        {
            InvoiceGenerator uc1 = new();
            double fare1 = uc1.CalculateFare(10, 30);
            Assert.AreEqual(130, fare1);
        }

        [TestMethod()]
        public void CalculateFareTest1()
        {
            InvoiceGenerator uc2 = new();
            MultipleRides[] rides = { new MultipleRides(10, 20), new MultipleRides(15, 25) };
            double totalfare = uc2.CalculateFare(rides);
            Assert.AreEqual(295, totalfare);
        }
    }
}