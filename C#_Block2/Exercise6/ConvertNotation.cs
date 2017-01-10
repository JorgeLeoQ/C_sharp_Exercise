using System;

namespace Exercise6
{
    public class ConvertNotation
    {
        static void Main(string[] args)
        {
            int number;
            ConsoleKeyInfo getChar;
            string binaryNotation = null;
            string hexNotation = null;

            Console.WriteLine("Application for convertion.");

            Console.Write("Enter decimal number: ");
            while ((int.TryParse(Console.ReadLine(), out number)) == false)
            {
                Console.WriteLine("Error. Enter a valid value: ");
            }

            Console.WriteLine("\nFrom decimal to binary.");
            DecimalToBinary(number);
            Console.WriteLine("\nFrom decimal to hexadecimal.");
            DecimalToHex();

            //another conversion
            Console.WriteLine("\nFrom binary to decimal.");
            Console.WriteLine("\nATTENTIONS!!. Only bits 0 and 1 are taken.");
            Console.Write("Enter binary number: ");
            do
            {
                getChar = Console.ReadKey();
                if (getChar.KeyChar == '0' || getChar.KeyChar == '1')
                {
                    binaryNotation += getChar.KeyChar;
                }
            }
            while (getChar.Key != ConsoleKey.Enter);
            BinaryToDecimal(binaryNotation);

            //another conversion
            Console.WriteLine("\nFrom hexadecimal to decimal.");
            Console.WriteLine("\nATTENTIONS!!.Only hexadecimali numbers\\characters will be considered (WRITE IN UPPERCASE).");
            Console.Write("Enter Hexadecimal number: ");

            do
            {
                getChar = Console.ReadKey();
                if (getChar.KeyChar == '0' || getChar.KeyChar == '1' || getChar.KeyChar == '2' || getChar.KeyChar == '3'
                    || getChar.KeyChar == '4' || getChar.KeyChar == '5' || getChar.KeyChar == '6' || getChar.KeyChar == '7' || getChar.KeyChar == '8'
                    || getChar.KeyChar == '9' || getChar.KeyChar == 'A' || getChar.KeyChar == 'B' || getChar.KeyChar == 'C' || getChar.KeyChar == 'D'
                    || getChar.KeyChar == 'E' || getChar.KeyChar == 'F')
                {
                    hexNotation += getChar.KeyChar;
                }
            }
            while (getChar.Key != ConsoleKey.Enter);

            HexToDecimal(hexNotation);
        }

        static public string DecimalToBinary(int num)
        {
            string convertDTB = Convert.ToString(num, 2);
            Console.WriteLine("Decimal {0} --> Binary {1}.", num, convertDTB);
            return convertDTB;
        }

        static public int BinaryToDecimal(string bNotation)
        {
            int decimalVal = Convert.ToInt32(bNotation, 2);
            Console.WriteLine("Binary: {0} --> Decimal: {1}.", bNotation, Convert.ToString(decimalVal));
            return decimalVal;
        }

        static public void DecimalToHex()
        {
            int number;

            Console.Write("Enter decimal number: ");
            while ((int.TryParse(Console.ReadLine(), out number)) == false)
            {
                Console.WriteLine("Error. Enter a valid value: ");
            }

            Console.WriteLine("Decimal: {0} --> Hexadecimal: {0:X}.", number, number);
        }

        static public int HexToDecimal(string hNotation)
        {
            int decimalVal = Convert.ToInt32(hNotation, 16);
            Console.WriteLine("Hexadecimal: {0} --> Decimal {1}.", hNotation, decimalVal);
            return decimalVal;
        }
    }
}
