using System;

namespace Exercise4
{
    public class ConvertString
    {
        static void Main(string[] args)
        {
            int number = 0;
            Console.WriteLine("That program convert a number to string.\n");

            while (true)
            {
                Console.Write("Enter a positive integer (0 < n < 999): ");
                while (!((int.TryParse(Console.ReadLine(), out number)) && (number >= 0 && number <= 999)))
                {
                    Console.Write("\nERROR. Enter a valid value: ");
                }

                Console.WriteLine("{0} --> {1}", number, ConvtDigitToString(number));
            }
        }

        static public string ConvtDigitToString(int num)
        {
            if (num == 0)
            {
                return "Zero";
            }
            else
            {
                int hundredsPart = num / 100;
                num %= 100;
                int dozensPart = num / 10;
                string stringHundreds = null;
                string stringDozens = null;
                string unitString = null;

                if (hundredsPart != 0)
                {

                    switch (hundredsPart)
                    {
                        case 1: stringHundreds = "One hundred "; break;
                        case 2: stringHundreds = "Two hundred "; break;
                        case 3: stringHundreds = "Three hundred "; break;
                        case 4: stringHundreds = "Four hundred "; break;
                        case 5: stringHundreds = "Five hundred "; break;
                        case 6: stringHundreds = "Six hundred "; break;
                        case 7: stringHundreds = "Seven hundred "; break;
                        case 8: stringHundreds = "Eight hundred "; break;
                        case 9: stringHundreds = "Nine hundred "; break;
                        default: stringHundreds = " "; break;
                    }

                }

                if (dozensPart > 1)
                {
                    num %= 10;

                    switch (dozensPart)
                    {
                        case 2: stringDozens = "twenty "; break;
                        case 3: stringDozens = "thirty "; break;
                        case 4: stringDozens = "forty "; break;
                        case 5: stringDozens = "fifty"; break;
                        case 6: stringDozens = "sixty "; break;
                        case 7: stringDozens = "seventy "; break;
                        case 8: stringDozens = "eighty "; break;
                        case 9: stringDozens = "ninety "; break;
                        default: stringDozens = " "; break;
                    }
                }
                else if (hundredsPart != 0 && hundredsPart >= 0)
                {
                    stringDozens = "and ";
                }

                switch (num)
                {
                    case 1: unitString = "one"; break;
                    case 2: unitString = "two"; break;
                    case 3: unitString = "three"; break;
                    case 4: unitString = "for"; break;
                    case 5: unitString = "five"; break;
                    case 6: unitString = "six"; break;
                    case 7: unitString = "seven"; break;
                    case 8: unitString = "eight"; break;
                    case 9: unitString = "nine"; break;
                    case 10: unitString = "ten"; break;
                    case 11: unitString = "eleven"; break;
                    case 12: unitString = "twelve"; break;
                    case 13: unitString = "thirteen"; break;
                    case 14: unitString = "fourteen"; break;
                    case 15: unitString = "fifteen"; break;
                    case 16: unitString = "sixteen"; break;
                    case 17: unitString = "seventeen"; break;
                    case 18: unitString = "eighteen"; break;
                    case 19: unitString = "nineteen"; break;
                    default: unitString = " "; break;
                }

                return stringHundreds + stringDozens + unitString;
            }
        }
    }
}
