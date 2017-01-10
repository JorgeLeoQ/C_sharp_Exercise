using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise8;

namespace UnitTest
{
    [TestClass]
    public class UnitTest8
    {
        Employee firstEmployee = new Employee("Mario", "Rossi", new DateTime(1980, 5, 30), "marioRossi@example.com", 500.00m, "Via inventata");
        
        [TestMethod]
        public void TestFirstEmployee()
        {
            Assert.AreEqual("Mario", firstEmployee.FirstName);
            Assert.AreEqual("Rossi", firstEmployee.LastName);
            Assert.AreEqual(500.00m, firstEmployee.RetriveAmountDue());
        }

        [TestMethod]
        public void TestAddSalary()
        {
            firstEmployee.AddAmountDue(250.00m);
            Assert.AreEqual(750.00m, firstEmployee.RetriveAmountDue());
        }

        [TestMethod]
        public void TestMailingAddress()
        {
            Assert.AreEqual("Via inventata", firstEmployee.PaymentAddress());
        }
    }
}
