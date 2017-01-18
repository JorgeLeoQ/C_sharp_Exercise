using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Esame06072015;

namespace TestMuseo
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSala()
        {
            Sala nuovaSala = new Sala("NuovaSala", 1);
            Assert.IsNotNull(nuovaSala);
            Assert.IsTrue(nuovaSala is Sala);
            Assert.AreEqual("NuovaSala", nuovaSala.Nome);
            Assert.AreEqual(1, nuovaSala.NumeroUnivoco);
        }
    }
}
