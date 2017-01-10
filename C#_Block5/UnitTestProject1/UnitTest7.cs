using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise7;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest07
    {
        Point[] points;
        [TestInitialize]
        public void InitilizzePoint()
        {
            points = new Point[]
            {
                new Point (1,3),
                new Point (9,6),
                new Point (-3,9),
                new Point (-4,-3),
                new Point (1,-1),
                new Point (0,0),
            };
        }
        static bool NeaarZeroP(Point boolP)
        {
            return Math.Abs(boolP.X + boolP.Y) <= 0.000001;
        }

        [TestMethod]
        public void TestSumZeroWithDelegate()
        {
            Point sumToZero = Array.Find(points, delegate (Point delP) { return Math.Abs(delP.X + delP.Y) <= 0.000001; });
            Assert.IsTrue(Math.Abs(sumToZero.X + sumToZero.Y) <= 0.000001);
        }
        [TestMethod]
        public void TestSumZeroWithStaticMethod()
        {
            Point sumToZero = Array.Find(points, NeaarZeroP);
            Assert.IsTrue(Math.Abs(sumToZero.X + sumToZero.Y) <= 0.000001);
        }
        [TestMethod]
        public void TestSortPoints()
        {
            Array.Sort(points, delegate (Point a, Point b) { return ComparePoint(a, b); });
            Assert.AreEqual(-4, points[0].X, 0.000001);
            Assert.AreEqual(-3, points[0].Y, 0.000001);
            Assert.AreEqual(0, points[2].X, 0.000001);
            Assert.AreEqual(0, points[2].Y, 0.000001);
            Assert.AreEqual(9, points[5].X, 0.000001);
            Assert.AreEqual(6, points[5].Y, 0.000001);
        }

        int ComparePoint(Point a, Point b)
        {
            if (a.X + a.Y > b.X + b.Y)
                return 1;
            else if (a.X + a.Y < b.X + b.Y)
                return -1;
            else
                return 0;
        }
    }
}
