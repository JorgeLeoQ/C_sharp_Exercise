using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise4;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest4
    {
        [TestMethod]
        public void TestSumComplex()
        {
            Complex complex1 = new Complex(1, 2);
            Complex complex2 = new Complex(2, 3);
            Complex sum = complex1 + complex2;

            Assert.AreEqual(3, sum.PartReal);
            Assert.AreEqual(5, sum.PartImm);

        }
        [TestMethod]
        public void TestSubctractComplex()
        {
            Complex complex1 = new Complex(1, 2);
            Complex complex2 = new Complex(2, 3);
            Complex sub = complex1 - complex2;

            Assert.AreEqual(-1, sub.PartReal);
            Assert.AreEqual(-1, sub.PartImm);
        }
        [TestMethod]
        public void TestMultiplyComplex()
        {
            Complex complex1 = new Complex(1, 2);
            Complex complex2 = new Complex(2, 3);
            Complex mult = complex1 * complex2;

            Assert.AreEqual(-4, mult.PartReal);
            Assert.AreEqual(7, mult.PartImm);
        }
        [TestMethod]
        public void TestDivisionComplex()
        {
            Complex complex1 = new Complex(1, 0);
            Complex complex2 = new Complex(0, 1);
            Complex div = complex1 / complex2;

            Assert.AreEqual(0, div.PartReal);
            Assert.AreEqual(-1, div.PartImm);
        }
        [TestMethod]
        public void TestConjugateomplex()
        {
            Complex complex1 = new Complex(1, 2);
            Complex complexConjugate = ~complex1;

            Assert.AreEqual(1, complexConjugate.PartReal);
            Assert.AreEqual(-2, complexConjugate.PartImm);
        }

        [TestMethod]
        public void TestToStringComplex()
        {
            Complex complex = new Complex(5, 9);
            Complex complexReal = new Complex(1, 0);

            Assert.AreEqual("5 + j9", complex.ToString());
            Assert.AreEqual("1", complexReal.ToString());
        }

        [TestMethod]
        public void TestConversionTB()
        {
            TriBool tb = new TriBool(TriBoolState.False);
            bool boolTrue = true;

            TriBool boolT = boolTrue;
            bool boolF = (bool)tb;

            Assert.AreEqual(false, boolF);
            Assert.AreEqual(TriBool.True, boolT);

        }

        [TestMethod]
        public void TestLogicTB()
        {
            TriBool tribool1 = new TriBool(TriBoolState.False);
            TriBool tribool2 = new TriBool(TriBoolState.True);
            TriBool tribool3 = new TriBool(TriBoolState.Indeterminate);
            Assert.AreEqual(TriBool.Indeterminate, !tribool3);
            Assert.AreEqual(TriBool.False, tribool1 & tribool2);
            Assert.AreEqual(TriBool.True, tribool1 | tribool2);
        }

        [TestMethod]
        public void TestComparisonTB()
        {
            TriBool tribool1 = new TriBool(TriBoolState.False);
            TriBool tribool2 = new TriBool(TriBoolState.False);

            Assert.AreEqual(TriBool.True, tribool1 == tribool2);
            Assert.AreEqual(TriBool.False, tribool1 != tribool2);

        }


    }
}
