using System;
using System.Numerics;

namespace Exercise2
{
    public class FibonacciClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("That application show you, the first 100 numbers in Fibonacci sequence.\n");

            //array with 100 scalar
            BigInteger[] fibonacciSequ = FibonacciSeq(101);

            for (int counterM = 0; counterM < fibonacciSequ.Length; counterM++)
            {
                Console.WriteLine("Fibonacci({0}) = {1}", counterM, fibonacciSequ[counterM]);
            }
        }

        static public BigInteger[] FibonacciSeq(int maxValue)
        {
            BigInteger[] fibonacci = new BigInteger[maxValue];
            BigInteger fibonacci1 = 0; //temporary variables 
            BigInteger fibonacci2 = 1;
            BigInteger total = 1;

            if (maxValue > 0)
            {
                fibonacci[0] = fibonacci1;
            }
            if(maxValue > 1)
            { 
                fibonacci[1] = fibonacci2;
            }

            for (int counter = 2; counter < fibonacci.Length; counter++)
            {
                total = fibonacci1 + fibonacci2;
                fibonacci1 = fibonacci2;
                fibonacci2 = total;
                fibonacci[counter] = total;
            }

            return fibonacci;
        }
    }
}
