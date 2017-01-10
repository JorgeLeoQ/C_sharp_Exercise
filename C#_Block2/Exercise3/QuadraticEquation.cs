using System;

namespace Exercise3
{
    public class QuadraticEquation
    {
        static void Main(string[] args)
        {
            int a, b, c; //parameter quadratic equation
            float[] result;

            Console.WriteLine("That Aplication resolve a quadratic equation (ax^2 + bx + c).\n");

            Console.Write("Enter \"a\" parametre: ");
            while ((int.TryParse(Console.ReadLine(), out a)) == false || (a == 0))
            {
                Console.Write("Error. Enter a valid value: ");
            }
            Console.Write("Enter \"b\" parametre: ");
            while ((int.TryParse(Console.ReadLine(), out b)) == false)
            {
                Console.Write("Error. Enter a valid value: ");
            }
            Console.Write("Enter \"c\" parametre: ");
            while ((int.TryParse(Console.ReadLine(), out c)) == false)
            {
                Console.Write("Error. Enter a valid value: ");
            }

            result = quadraticEquation(a, b, c);
            Console.WriteLine("x1 = {0} V x2 = {1}", result[0], result[1]);
        }

        static public float[] quadraticEquation(int aP, int bP, int cP)
        {
            float[] roots = new float[2];

            if (aP == 0)
            {
                Console.WriteLine("Error. parametre \"a\" have to be different to zero.");
                return roots;
            }
            else
            {
                float delta;

                //calcolate delta
                delta = ((float)Math.Pow(bP, 2) - (4 * aP * cP));

                if (delta > 0)
                {
                    roots[0] = (-1 * bP + (float)Math.Sqrt(delta)) / (2 * aP);
                    roots[1] = (-1 * bP - (float)Math.Sqrt(delta)) / (2 * aP);

                    Console.WriteLine("There are two different roots.");
                }
                else if (delta == 0)
                {
                    roots[0] = roots[1] = (-1 * bP) / (2 * aP);

                    Console.WriteLine("There are two coincident roots.");
                }
                else
                {
                    Console.WriteLine("Negative delta, there are two roots complex conjugates");
                    roots[0] = roots[1] = 0;
                }

                return roots;
            }
        }
    }
}
