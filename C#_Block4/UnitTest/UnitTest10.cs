using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise10;

namespace UnitTest
{
    [TestClass]
    public class UnitTest10
    {
        [TestMethod]
        public void TestSumOfSalaryEmployee()
        {
            Double trueMoneyProfit = 350;
            Double sumProfit = 0;
            SalaryWorker annualOne = new SalaryWorker("AnnualFirst",1200); //100
            SalaryWorker annualTwo = new SalaryWorker("AnnualSecond",1200); //100
            HourlyWorker HourlyOne = new HourlyWorker("HorlyFirst", 10,5); //50
            HourlyWorker HourlyTwo = new HourlyWorker("HorlySecond",20,5);//100
            Employee[] Employees = new Employee[] { annualOne, annualTwo, HourlyOne, HourlyTwo };
            foreach (var element in Employees)
            {
                sumProfit = sumProfit + element.calcPaidCheck();
            }
            Assert.AreEqual(trueMoneyProfit,sumProfit); //Employees[0].calcPaidCheck()
        }
    }
}
