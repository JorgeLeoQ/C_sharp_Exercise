using System;
using System.Numerics;

namespace Exercise5
{
    public class SumPolynomio
    {
        static void Main(string[] args)
        {

            int x;
            int n;

            Console.WriteLine("That program, calculates the sum: S = 1 + 1!/X + 2!/X^2 + ... + N!/X^N.\n");

            Console.Write("Enter integer \"X\" parametre: ");
                while ((int.TryParse(Console.ReadLine(), out x)) == false || (x == 0))
            {
                Console.Write("Error!!. Enter a valid value: ");
            }
            Console.Write("Enter positive integer \"N\" parametre: ");
            while ((int.TryParse(Console.ReadLine(), out n)) == false || (n < 0))
            {
                Console.Write("Error!!. Enter a valid value: ");
            }

            Console.WriteLine("The sum is: " + PolynomialSum(x, n));

        }

        //method that calculate the polynomial sum
        public static double PolynomialSum(int x, int n)
        {
            double totalSum = 1;

            if (n == 0)
            {
                return totalSum;
            }
            else
            {
                for (int counter = 1; counter <= n; counter++)
                {
                    totalSum += ((double)Factorial(counter) / (Math.Pow(x, counter)));
                }
            }

            return totalSum;
        }

        //method calculate Factorial number
        public static BigInteger Factorial(int number)
        {
            BigInteger totalFac = 1;
            do
            {
                totalFac *= number;
                number--;
            }
            while (number > 0);

            return totalFac;
        }
    }
}
