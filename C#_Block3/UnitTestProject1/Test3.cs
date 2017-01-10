using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using System.IO;
using Exercise3;

namespace UnitTestProject1
{
    [TestClass]
    public class Test3
    {
        static string path = @"..\..\..\Exercise3\TestFolder";

        [TestMethod]
        public void TestArrayFilesAndDirectory()
        {
            string[] expected = { "..\\..\\..\\Exercise3\\TestFolder\\file1.txt" ,
                                  "..\\..\\..\\Exercise3\\TestFolder\\file2.txt",
                                  "..\\..\\..\\Exercise3\\TestFolder\\file3.txt",
                                  "..\\..\\..\\Exercise3\\TestFolder\\folder1\\",
                                  "..\\..\\..\\Exercise3\\TestFolder\\folder1\\file1.1.txt",
                                  "..\\..\\..\\Exercise3\\TestFolder\\folder1\\file1.2.txt",
                                  "..\\..\\..\\Exercise3\\TestFolder\\folder2\\",
                                  "..\\..\\..\\Exercise3\\TestFolder\\folder2\\folder2.1\\",
                                  "..\\..\\..\\Exercise3\\TestFolder\\folder2\\folder2.1\\file2.1.1.txt",
                                  "..\\..\\..\\Exercise3\\TestFolder\\folder3\\"};

            CollectionAssert.AreEqual(expected, PrintSubFoulderAndFiles.TraverseFoulder(path));
        }
    }
}
