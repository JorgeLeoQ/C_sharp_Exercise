using System;
using System.Text;


namespace Exercise2
{
    public class SumLongIntegers
    {
        //Method to sum two very long positive integer numbers
        public static string SumLong(string firstStringN, string secondStringN)
        {
            int remainder = 0;
            string currentDigit;
            int digitInteger;
            int sum;
            int maxLenght;

            //revesed the following strings, for sum term by term from last digits
            string firstStringNRev = ReverseString(firstStringN);
            string secondStringNRev = ReverseString(secondStringN);

            //find the max lenght between the strings
            maxLenght = firstStringNRev.Length;
            if (secondStringNRev.Length > maxLenght)
            {
                maxLenght = secondStringNRev.Length;
            }

            //build a new string
            StringBuilder totalSum = new StringBuilder();

            for (int i = 0; i < maxLenght; i++)
            {
                sum = remainder;
                if (i < firstStringNRev.Length)
                {
                    currentDigit = Convert.ToString(firstStringNRev[i]);
                    digitInteger = int.Parse(currentDigit);
                    sum += digitInteger;
                }
                if (i < secondStringNRev.Length)
                {
                    currentDigit = Convert.ToString(secondStringNRev[i]);
                    int digitSecondNumber = int.Parse(currentDigit);
                    sum += digitSecondNumber;
                }

                remainder = sum / 10; //check if the number is greater than 9
                //Appends the string
                if (remainder > 0)
                {
                    totalSum.Append(sum % 10);
                }
                else
                {
                    totalSum.Append(sum);
                }
            }

            if (remainder > 0)
            {
                totalSum.Append(remainder);
            }

            string returnSum = ReverseString(Convert.ToString(totalSum));
            return returnSum;
        }

        //Method to reversed the string 
        private static string ReverseString(string stringN)
        {
            StringBuilder reverse = new StringBuilder();
            for (int counter = stringN.Length - 1; counter >= 0; counter--)
            {
                reverse.Append(stringN[counter]);
            }

            return Convert.ToString(reverse);
        }

        static void Main(string[] args)
        {
        }
    }
}