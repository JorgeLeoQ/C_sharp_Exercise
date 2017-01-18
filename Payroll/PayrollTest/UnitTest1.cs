using System;
using Payroll;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PayrollTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddSalariedEmployee()
        {

            int empId = 1;
            AddSalariedEmployee t = new AddSalariedEmployee(empId, "Bob", "Home", 1000.00);
            t.Execute();
            Employee e = PayrollDatabase.GetEmployee(empId);
            Assert.AreEqual("Bob", e.Name);
            PaymentClassification pc = e.Classification;
            Assert.IsTrue(pc is SalariedClassification);
            SalariedClassification sc = pc as SalariedClassification;
            Assert.AreEqual(1000.00, sc.Salary, .001);
            PaymentSchedule ps = e.Schedule;
            Assert.IsTrue(ps is MonthlySchedule);
            PaymentMethod pm = e.Method;
            Assert.IsTrue(pm is HoldMethod);
        }
        [TestMethod]
        public void TestAddHourlyEmployee()
        {
            int empId = 2;
            AddHourlyEmployee t = new AddHourlyEmployee(empId, "John", "Home", 50.00);
            t.Execute();
            Employee e = PayrollDatabase.GetEmployee(empId);
            Assert.AreEqual("John", e.Name);
            PaymentClassification pc = e.Classification;
            Assert.IsTrue(pc is HourlyClassification);
            HourlyClassification sc = pc as HourlyClassification;
            Assert.AreEqual(50.00, sc.HourlyRate, .001);
            PaymentSchedule ps = e.Schedule;
            Assert.IsTrue(ps is WeeklySchedule);
            PaymentMethod pm = e.Method;
            Assert.IsTrue(pm is HoldMethod);
        }
        [TestMethod]
        public void TestAddCommissionedEmployee()
        {
            int empId = 3;
            AddCommissionedEmployee t = new AddCommissionedEmployee(empId, "Paul", "Home", 1000.00, 1.5);
            t.Execute();
            Employee e = PayrollDatabase.GetEmployee(empId);
            Assert.AreEqual("Paul", e.Name);
            PaymentClassification pc = e.Classification;
            Assert.IsTrue(pc is CommissionedClassification);
            CommissionedClassification sc = pc as CommissionedClassification;
            Assert.AreEqual(1.5, sc.CommissionRate, .001);
            Assert.AreEqual(1000.00, sc.Salary, .001);
            PaymentSchedule ps = e.Schedule;
            Assert.IsTrue(ps is BiWeeklySchedule);
            PaymentMethod pm = e.Method;
            Assert.IsTrue(pm is HoldMethod);
        }

        [TestMethod]
        public void DeleteEmployee()
        {
            int empId = 4;
            AddCommissionedEmployee t = new AddCommissionedEmployee(empId, "Bill", "Home", 2500, 3.2);
            t.Execute();
            Employee e = PayrollDatabase.GetEmployee(empId);
            Assert.IsNotNull(e);
            DeleteEmployeeTransaction dt = new DeleteEmployeeTransaction(empId);
            dt.Execute();
            e = PayrollDatabase.GetEmployee(empId);
            Assert.IsNull(e);
        }

        [TestMethod]
        public void TestTimeCardTransaction()
        {
            int empId = 5;
            AddHourlyEmployee t = new AddHourlyEmployee(empId, "Bill", "Home", 15.25);
            t.Execute();
            TimeCardTransaction tct = new TimeCardTransaction(new DateTime(2005, 7, 31), 8.0, empId);
            tct.Execute();
            Employee e = PayrollDatabase.GetEmployee(empId);
            Assert.IsNotNull(e);
            PaymentClassification pc = e.Classification;
            Assert.IsTrue(pc is HourlyClassification);
            HourlyClassification hc = pc as HourlyClassification;
            TimeCard tc = hc.GetTimeCard(new DateTime(2005, 7, 31));
            Assert.IsNotNull(tc);
            Assert.AreEqual(8.0, tc.Hours);
        }

        [TestMethod]
        public void AddServiceCharge()
        {
            int empId = 2;
            AddHourlyEmployee t = new AddHourlyEmployee(empId, "Bill", "Home", 15.25);
            t.Execute();
            Employee e = PayrollDatabase.GetEmployee(empId);
            Assert.IsNotNull(e);
            UnionAffiliation af = new UnionAffiliation();
            e.Affiliation = af;
            int memberId = 86;
            PayrollDatabase.AddUnionMember(memberId, e);
            ServiceChargeTransaction sct = new ServiceChargeTransaction(memberId, new DateTime(2005, 8, 8), 12.95);
            sct.Execute();
            ServiceCharge sc = af.GetServiceCharge(new DateTime(2005, 8, 8));
            Assert.IsNotNull(sc);
            Assert.AreEqual(12.95, sc.Amount, .001);
        }

        [TestMethod]
        public void TestChangeNameTransaction()
        {
            int empId = 2;
            AddHourlyEmployee t =
            new AddHourlyEmployee(empId, "Bill", "Home", 15.25);
            t.Execute();
            ChangeNameTransaction cnt =
            new ChangeNameTransaction(empId, "Bob");
            cnt.Execute();
            Employee e = PayrollDatabase.GetEmployee(empId);
            Assert.IsNotNull(e);
            Assert.AreEqual("Bob", e.Name);
        }

        [TestMethod]
        public void TestChangeAddressTransaction()
        {
            int empId = 2;
            AddHourlyEmployee t =
            new AddHourlyEmployee(empId, "Bill", "Home", 15.25);
            t.Execute();
            ChangeAddressTransaction cnt =
            new ChangeAddressTransaction(empId, "Home2");
            cnt.Execute();
            Employee e = PayrollDatabase.GetEmployee(empId);
            Assert.IsNotNull(e);
            Assert.AreEqual("Home2", e.Address);
        }

        [TestMethod]
        public void TestChangeHourlyTransaction()
        {
            int empId = 3;
            AddCommissionedEmployee t =
            new AddCommissionedEmployee(
            empId, "Lance", "Home", 2500, 3.2);
            t.Execute();
            ChangeHourlyTransaction cht = new ChangeHourlyTransaction(empId, 27.52);
            cht.Execute();
            Employee e = PayrollDatabase.GetEmployee(empId);
            Assert.IsNotNull(e);
            PaymentClassification pc = e.Classification;
            Assert.IsNotNull(pc);
            Assert.IsTrue(pc is HourlyClassification);
            HourlyClassification hc = pc as HourlyClassification;
            Assert.AreEqual(27.52, hc.HourlyRate, .001);
            PaymentSchedule ps = e.Schedule;
            Assert.IsTrue(ps is WeeklySchedule);
        }

        [TestMethod]
        public void TestChangeSalariedTransaction()
        {
            int empId = 3;
            AddCommissionedEmployee t = new AddCommissionedEmployee(empId, "Lance", "Home", 2500, 3.2);
            t.Execute();
            ChangeSalariedTransaction cht = new ChangeSalariedTransaction(empId, 1000.00);
            cht.Execute();
            Employee e = PayrollDatabase.GetEmployee(empId);
            Assert.IsNotNull(e);
            PaymentClassification pc = e.Classification;
            Assert.IsNotNull(pc);
            Assert.IsTrue(pc is SalariedClassification);
            SalariedClassification sc = pc as SalariedClassification;
            Assert.AreEqual(1000.00, sc.Salary, .001);
            PaymentSchedule ps = e.Schedule;
            Assert.IsTrue(ps is MonthlySchedule);
        }

        [TestMethod]
        public void TestChangeCommissionedTransaction()
        {
            int empId = 3;
            AddHourlyEmployee t = new AddHourlyEmployee(empId, "Lance", "Home", 3.2);
            t.Execute();
            ChangeCommissionedTransaction cht = new ChangeCommissionedTransaction(empId, 2500, 3.2);
            cht.Execute();
            Employee e = PayrollDatabase.GetEmployee(empId);
            Assert.IsNotNull(e);
            PaymentClassification pc = e.Classification;
            Assert.IsNotNull(pc);
            Assert.IsTrue(pc is CommissionedClassification);
            CommissionedClassification cc = pc as CommissionedClassification;
            Assert.AreEqual(2500.00, cc.Salary, .001);
            Assert.AreEqual(3.2, cc.CommissionRate, .001);
            PaymentSchedule ps = e.Schedule;
            Assert.IsTrue(ps is BiWeeklySchedule);
        }

        [TestMethod]
        public void TestChangeDirectTransaction()
        {
            int empId = 3;
            AddCommissionedEmployee t =
            new AddCommissionedEmployee(empId, "Lance", "Home", 2500, 3.2);
            t.Execute();
            ChangeDirectTransaction cdt = new ChangeDirectTransaction(empId, "Bank", "Account");
            cdt.Execute();
            Employee e = PayrollDatabase.GetEmployee(empId);
            Assert.IsNotNull(e);
            PaymentMethod pm = e.Method;
            Assert.IsNotNull(pm);
            Assert.IsTrue(pm is DirectDepositMethod);
            DirectDepositMethod dm = pm as DirectDepositMethod;
            Assert.AreEqual("Bank", dm.Bank);
            Assert.AreEqual("Account", dm.AccountNumber);
        }
        [TestMethod]
        public void TestChangeMailTransaction()
        {
            int empId = 3;
            AddCommissionedEmployee t =
            new AddCommissionedEmployee(empId, "Lance", "Home", 2500, 3.2);
            t.Execute();
            ChangeMailTransaction cmt = new ChangeMailTransaction(empId, "Home");
            cmt.Execute();
            Employee e = PayrollDatabase.GetEmployee(empId);
            Assert.IsNotNull(e);
            PaymentMethod pm = e.Method;
            Assert.IsNotNull(pm);
            Assert.IsTrue(pm is MailMethod);
            MailMethod mm = pm as MailMethod;
            Assert.AreEqual("Home", mm.Address);
        }
        [TestMethod]
        public void TestChangeHoldTransaction()
        {
            int empId = 3;
            AddCommissionedEmployee t =
            new AddCommissionedEmployee(empId, "Lance", "Home", 2500, 3.2);
            t.Execute();
            ChangeHoldTransaction cht = new ChangeHoldTransaction(empId);
            cht.Execute();
            Employee e = PayrollDatabase.GetEmployee(empId);
            Assert.IsNotNull(e);
            PaymentMethod pm = e.Method;
            Assert.IsNotNull(pm);
            Assert.IsTrue(pm is HoldMethod);
        }

        [TestMethod]
        public void ChangeUnionMember()
        {
            int empId = 8;
            AddHourlyEmployee t =
            new AddHourlyEmployee(empId, "Bill", "Home", 15.25);
            t.Execute();
            int memberId = 7743;
            ChangeMemberTransaction cmt =
            new ChangeMemberTransaction(empId, memberId, 99.42);
            cmt.Execute();
            Employee e = PayrollDatabase.GetEmployee(empId);
            Assert.IsNotNull(e);
            Affiliation affiliation = e.Affiliation;
            Assert.IsNotNull(affiliation);
            Assert.IsTrue(affiliation is UnionAffiliation);
            UnionAffiliation uf = affiliation as UnionAffiliation;
            Assert.AreEqual(99.42, uf.Dues, .001);
            Employee member = PayrollDatabase.GetUnionMember(memberId);
            Assert.IsNotNull(member);
            Assert.AreEqual(e, member);
        }

        [TestMethod]
        public void PaySingleSalariedEmployee()
        {
            int empId = 1;
            AddSalariedEmployee t = new AddSalariedEmployee(
            empId, "Bob", "Home", 1000.00);
            t.Execute();
            DateTime payDate = new DateTime(2001, 11, 30);
            PaydayTransaction pt = new PaydayTransaction(payDate);
            pt.Execute();
            Paycheck pc = pt.GetPaycheck(empId);
            Assert.IsNotNull(pc);
            Assert.AreEqual(payDate, pc.PayDate);
            Assert.AreEqual(1000.00, pc.GrossPay, .001);
            Assert.AreEqual("Hold", pc.GetField("Disposition"));
            Assert.AreEqual(0.0, pc.Deductions, .001);
            Assert.AreEqual(1000.00, pc.NetPay, .001);
        }
        [TestMethod]
        public void PaySingleSalariedEmployeeOnWrongDate()
        {
            int empId = 1;
            AddSalariedEmployee t = new AddSalariedEmployee(
            empId, "Bob", "Home", 1000.00);
            t.Execute();
            DateTime payDate = new DateTime(2001, 11, 29);
            PaydayTransaction pt = new PaydayTransaction(payDate);
            pt.Execute();
            Paycheck pc = pt.GetPaycheck(empId);
            Assert.IsNull(pc);
        }
        [TestMethod]
        public void PayingSingleHourlyEmployeeNoTimeCards()
        {
            int empId = 2;
            AddHourlyEmployee t = new AddHourlyEmployee(
            empId, "Bill", "Home", 15.25);
            t.Execute();
            DateTime payDate = new DateTime(2001, 11, 9);
            PaydayTransaction pt = new PaydayTransaction(payDate);
            pt.Execute();
            ValidateHourlyPaycheck(pt, empId, payDate, 0.0);
        }
        private void ValidateHourlyPaycheck(PaydayTransaction pt,
        int empid, DateTime payDate, double pay)
        {
            Paycheck pc = pt.GetPaycheck(empid);
            Assert.IsNotNull(pc);
            Assert.AreEqual(payDate, pc.PayDate);
            Assert.AreEqual(pay, pc.GrossPay, .001);
            Assert.AreEqual("Hold", pc.GetField("Disposition"));
            Assert.AreEqual(0.0, pc.Deductions, .001);
            Assert.AreEqual(pay, pc.NetPay, .001);
        }

        [TestMethod]
        public void PaySingleHourlyEmployeeOneTimeCard()
        {
            int empId = 2;
            AddHourlyEmployee t = new AddHourlyEmployee(
            empId, "Bill", "Home", 15.25);
            t.Execute();
            DateTime payDate = new DateTime(2001, 11, 9); // Friday
            TimeCardTransaction tc =
            new TimeCardTransaction(payDate, 2.0, empId);
            tc.Execute();
            PaydayTransaction pt = new PaydayTransaction(payDate);
            pt.Execute();
            ValidateHourlyPaycheck(pt, empId, payDate, 30.5);
        }
        [TestMethod]
        public void PaySingleHourlyEmployeeOvertimeOneTimeCard()
        {
            int empId = 2;
            AddHourlyEmployee t = new AddHourlyEmployee(
            empId, "Bill", "Home", 15.25);
            t.Execute();
            DateTime payDate = new DateTime(2001, 11, 9); // Friday
            TimeCardTransaction tc =
            new TimeCardTransaction(payDate, 9.0, empId);
            tc.Execute();
            PaydayTransaction pt = new PaydayTransaction(payDate);
            pt.Execute();
            ValidateHourlyPaycheck(pt, empId, payDate, (8 + 1.5) * 15.25);
        }
        [TestMethod]
        public void PaySingleHourlyEmployeeOnWrongDate()
        {
            int empId = 2;
            AddHourlyEmployee t = new AddHourlyEmployee(
            empId, "Bill", "Home", 15.25);
            t.Execute();
            DateTime payDate = new DateTime(2001, 11, 8); // Thursday
            TimeCardTransaction tc =
            new TimeCardTransaction(payDate, 9.0, empId);
            tc.Execute();
            PaydayTransaction pt = new PaydayTransaction(payDate);
            pt.Execute();
            Paycheck pc = pt.GetPaycheck(empId);
            Assert.IsNull(pc);
        }
        [TestMethod]
        public void PaySingleHourlyEmployeeTwoTimeCards()
        {
            int empId = 2;
            AddHourlyEmployee t = new AddHourlyEmployee(
            empId, "Bill", "Home", 15.25);
            t.Execute();
            DateTime payDate = new DateTime(2001, 11, 9); // Friday
            TimeCardTransaction tc =
            new TimeCardTransaction(payDate, 2.0, empId);
            tc.Execute();
            TimeCardTransaction tc2 =
            new TimeCardTransaction(payDate.AddDays(-1), 5.0, empId);
            tc2.Execute();
            PaydayTransaction pt = new PaydayTransaction(payDate);
            pt.Execute();
            ValidateHourlyPaycheck(pt, empId, payDate, 7 * 15.25);
        }
        [TestMethod]
        public void TestPaySingleHourlyEmployeeWithTimeCardsSpanningTwoPayPeriods()
        {
            int empId = 2;
            AddHourlyEmployee t = new AddHourlyEmployee(
            empId, "Bill", "Home", 15.25);
            t.Execute();
            DateTime payDate = new DateTime(2001, 11, 9); // Friday
            DateTime dateInPreviousPayPeriod =
            new DateTime(2001, 11, 2);
            TimeCardTransaction tc =
            new TimeCardTransaction(payDate, 2.0, empId);
            tc.Execute();
            TimeCardTransaction tc2 = new TimeCardTransaction(
            dateInPreviousPayPeriod, 5.0, empId);
            tc2.Execute();
            PaydayTransaction pt = new PaydayTransaction(payDate);
            pt.Execute();
            ValidateHourlyPaycheck(pt, empId, payDate, 2 * 15.25);
        }

        [TestMethod]
        public void SalariedUnionMemberDues()
        {
            int empId = 1;
            AddSalariedEmployee t = new AddSalariedEmployee(empId, "Bob", "Home", 1000.00);
            t.Execute();
            int memberId = 7734;
            ChangeMemberTransaction cmt = new ChangeMemberTransaction(empId, memberId, 9.42);
            cmt.Execute();
            DateTime payDate = new DateTime(2001, 11, 30);
            PaydayTransaction pt = new PaydayTransaction(payDate);
            pt.Execute();
            Paycheck pc = pt.GetPaycheck(empId);
            Assert.IsNotNull(pc);
            Assert.AreEqual(payDate, pc.PayDate);
            Assert.AreEqual(1000.0, pc.GrossPay, .001);
            Assert.AreEqual("Hold", pc.GetField("Disposition"));
            Assert.AreEqual(9.42 * 5, pc.Deductions, .001);
            Assert.AreEqual(1000.00 - (9.42 * 5), pc.NetPay, .001);
        }

        [TestMethod]
        public void HourlyUnionMemberServiceCharge()
        {
            int empId = 1;
            AddHourlyEmployee t = new AddHourlyEmployee(
            empId, "Bill", "Home", 15.24);
            t.Execute();
            int memberId = 7734;
            ChangeMemberTransaction cmt =
            new ChangeMemberTransaction(empId, memberId, 9.42);
            cmt.Execute();
            DateTime payDate = new DateTime(2001, 11, 9);
            ServiceChargeTransaction sct =
            new ServiceChargeTransaction(memberId, payDate, 19.42);
            sct.Execute();
            TimeCardTransaction tct =
            new TimeCardTransaction(payDate, 8.0, empId);
            tct.Execute();
            PaydayTransaction pt = new PaydayTransaction(payDate);
            pt.Execute();
            Paycheck pc = pt.GetPaycheck(empId);
            Assert.IsNotNull(pc);
            Assert.AreEqual(payDate, pc.PayPeriodEndDate);
            Assert.AreEqual(8 * 15.24, pc.GrossPay, .001);
            Assert.AreEqual("Hold", pc.GetField("Disposition"));
            Assert.AreEqual(9.42 + 19.42, pc.Deductions, .001);
            Assert.AreEqual((8 * 15.24) - (9.42 + 19.42), pc.NetPay, .001);
        }

        [TestMethod]
        public void ServiceChargesSpanningMultiplePayPeriods()
        {
            int empId = 1;
            AddHourlyEmployee t = new AddHourlyEmployee(
            empId, "Bill", "Home", 15.24);
            t.Execute();
            int memberId = 7734;
            ChangeMemberTransaction cmt =
            new ChangeMemberTransaction(empId, memberId, 9.42);
            cmt.Execute();
            DateTime payDate = new DateTime(2001, 11, 9);
            DateTime earlyDate =
            new DateTime(2001, 11, 2); // previous Friday
            DateTime lateDate =
            new DateTime(2001, 11, 16); // next Friday
            ServiceChargeTransaction sct =
            new ServiceChargeTransaction(memberId, payDate, 19.42);
            sct.Execute();
            ServiceChargeTransaction sctEarly =
            new ServiceChargeTransaction(memberId, earlyDate, 100.00);
            sctEarly.Execute();
            ServiceChargeTransaction sctLate =
            new ServiceChargeTransaction(memberId, lateDate, 200.00);
            sctLate.Execute();
            TimeCardTransaction tct =
            new TimeCardTransaction(payDate, 8.0, empId);
            tct.Execute();
            PaydayTransaction pt = new PaydayTransaction(payDate);
            pt.Execute();
            Paycheck pc = pt.GetPaycheck(empId);
            Assert.IsNotNull(pc);
            Assert.AreEqual(payDate, pc.PayPeriodEndDate);
            Assert.AreEqual(8 * 15.24, pc.GrossPay, .001);
            Assert.AreEqual("Hold", pc.GetField("Disposition"));
            Assert.AreEqual(9.42 + 19.42, pc.Deductions, .001);
            Assert.AreEqual((8 * 15.24) - (9.42 + 19.42),
            pc.NetPay, .001);
        }
    }
}
