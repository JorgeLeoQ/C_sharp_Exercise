using System;

namespace Exercise1
{
    public class GreaterAndSmaller
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;

            Console.Write("Enter first integer: ");
            while (int.TryParse(Console.ReadLine(), out num1) == false)
            {
                Console.Write("Error. Enter a valid value: ");
            }

            Console.Write("Enter second integer: ");
            while (int.TryParse(Console.ReadLine(), out num2) == false)
            {
                Console.Write("Error. Enter a valid value: ");
            }

            Console.WriteLine("The smaller number is: " + Smaller(num1, num2));
            Console.WriteLine("The Greater number is: " + Greater(num1, num2));
        }
        //find greater number without using conditional statements
        public static int Greater(int num1, int num2)
        {
            int maxValue = ((num1 + num2) + Math.Abs(num1 - num2)) / 2;
            return maxValue;
        }
        //find smaller number without using conditional statements
        static public int Smaller(int num1, int num2)
        {
            int minNumber = ((num1 + num2) - Math.Abs(num1 - num2)) / 2;
            return minNumber;
        }
    }
}
