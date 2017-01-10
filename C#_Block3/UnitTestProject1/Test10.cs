using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise10;


namespace UnitTestProject1
{
    [TestClass]
    public class Test10
    {
        [TestMethod]
        public void TestOneWord()
        {
            string input = @"ciao ciao ciao ciao ciao ciao ciao ciao ciao ciao ciao ciao";
            object[,] words = CountWordInText.CountWords(input);
            object[,] result = new object[,]
            {
                {"ciao", 12}
            };
            CollectionAssert.AreEqual(words, result);
        }

        [TestMethod]
        public void TestMoreWord()
        {
            string input = @"my name is mario rossi";
            object[,] words = CountWordInText.CountWords(input);
            object[,] result = new object[,]
            {
                {"is", 1}, {"mario", 1 }, {"my", 1}, {"name", 1}, {"rossi", 1}
            };
            CollectionAssert.AreEqual(words, result);
        }

        [TestMethod]
        public void TestComplexStringText()
        {
            string input = @"Sempre caro mi fu quest’ermo colle,
                            E questa siepe, che da tanta parte
                            Dell’ultimo orizzonte il guardo esclude.
                            Ma sedendo e rimirando, interminati
                            Spazi di là da quella, e sovrumani
                            Silenzi, e profondissima quiete
                            Io nel pensier mi fingo, ove per poco
                            Il cor non si spaura. E come il vento
                            Odo stormir tra queste piante, io quello
                            Infinito silenzio a questa voce
                            Vo comparando: e mi sovvien l’eterno,
                            E le morte stagioni, e la presente
                            E viva, e il suon di lei. Così tra questa
                            Immensità s’annega il pensier mio:
                            E il naufragar m’è dolce in questo mare.";
            object[,] words = CountWordInText.CountWords(input);
            Assert.AreEqual("\r\n", words[0, 0]);
            Assert.AreEqual("il", words[18, 0]);
            Assert.AreEqual(77 * 2, words.Length);
            Assert.AreEqual(3, words[0, 1]);
            Assert.AreEqual(11, words[13, 1]);
        }
    }
}
