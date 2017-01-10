using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise5;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest5
    {
        Event newEvent = new Event();

        [TestInitialize]
        public void InitilizzePoint()
        {
            newEvent.AddParticipant(new Participant("Pippo", 75));
            newEvent.AddParticipant(new Participant("Topolino", 105));
            newEvent.AddParticipant(new Participant("Paperino", 98));
        }

        [TestMethod]
        public void TestUsingForEach()
        { 
            string[] resultFromNewEvent = new string[3];
            string[] expectedResult = new string[3] { "Pippo", "Topolino", "Paperino" };
            int counter = 0;

            foreach (var partecipante in newEvent)
            {
                resultFromNewEvent[counter] = partecipante.Name;
                counter++;
            }
            CollectionAssert.AreEquivalent(expectedResult, resultFromNewEvent);
        }
    }
}
