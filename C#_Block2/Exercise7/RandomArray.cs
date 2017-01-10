using System;

namespace Exercise7
{
    public class RandomArray
    {
        private static Random rnd = new Random();

        static void Main(string[] args)
        {
            int sizeArray;

            Console.Write("Enter a size of the array: ");
            while (!(int.TryParse(Console.ReadLine(), out sizeArray)) || (sizeArray <= 1))
            {
                Console.Write("Error. Enter a valid value: ");
            }

            int[] num = Randomizer(sizeArray);

            foreach (var item in num)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }

        public static int[] Randomizer(int n)
        {
            int[] num = new int[n];

            for (int i = 0; i < n; i++)
            {
                num[i] = i + 1;
            }

            for (int i = n - 1; i > 0; i--)
            {
                int j = rnd.Next(0, i + 1);

                int temp = num[i];
                num[i] = num[j];
                num[j] = temp;
            }
            return num;

        }
    }
}
