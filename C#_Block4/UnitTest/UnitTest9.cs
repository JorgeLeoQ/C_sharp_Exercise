using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise9;

namespace UnitTest
{
    [TestClass]
    public class UnitTest9
    {
        [TestMethod]
        public void TestMethod1()
        {
            Beverage bevOne = new Beverage("The", 1, 2, 3);
            Beverage bevTwo = new Beverage("Sprite", 1, 2, 3);
            Beverage bevThree = new Beverage("Coca", 1, 2, 3);
            Beverage bevFour = new Beverage("CocaZero", 1, 2, 3);
            Snack snackOne = new Snack("kitkat", 1);
            Snack snackTwo = new Snack("Bounty", 1);
            Snack snackThree = new Snack("Ringo", 1);
            MenuItem[] items = new MenuItem[] { bevOne, bevTwo, bevThree, bevFour, snackOne, snackTwo, snackThree };
            string ris = "********MENU***********\n";
            foreach (var element in items)
            {
                ris = ris + element.printToString();
            }
        }
    }
}
