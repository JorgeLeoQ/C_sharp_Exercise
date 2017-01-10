using System;

namespace Exercise8
{
    public class GCDandLCM
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;

            Console.WriteLine("That program find the LCM and GCD.\n");

            Console.Write("Enter first integer: ");
            while ((int.TryParse(Console.ReadLine(), out number1)) == false)
            {
                Console.Write("Error. Enter a valid value: ");
            }
            Console.Write("Enter second integer: ");
            while ((int.TryParse(Console.ReadLine(), out number2)) == false)
            {
                Console.Write("Error. Enter a valid value: ");
            }

            Console.WriteLine("The greatest common divisor is: {0}", Gcd(number1, number2));
            Console.WriteLine("The least common multiple is: {0}", Lcm(number1, number2));
        }

        public static int Gcd(int num1, int num2)
        {
            int remainder;

            while (num2 != 0)
            {
                remainder = num1 % num2;
                num1 = num2;
                num2 = remainder;
            }

            return num1;
        }

        public static int Lcm(int num1Lcm, int num2Lcm)
        {
            int valAbsolute = Math.Abs(num1Lcm * num2Lcm);
            int greatesCD = Gcd(num1Lcm, num2Lcm);
            if (greatesCD != 0)
            {
                return (valAbsolute / greatesCD);
            }
            else
            {
                return 0;
            }
        }
    }
}
