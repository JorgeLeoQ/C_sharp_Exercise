using System;

namespace Exercise9
{
    //maximal sequence of increasing elements
    public class MaximalSeqIncreElement
    {
        static void Main(string[] args)
        {
            int sizeArray;

            Console.Write("Enter the size array: ");
            while((int.TryParse(Console.ReadLine(), out sizeArray)) == false || (sizeArray <= 1))
            {
                Console.Write("Error!!. Enter a valid value: ");
            }

            int[] sequenceArray = new int[sizeArray];

            for (int i = 0; i < sequenceArray.Length; i++)
            {
                Console.Write("Enter a number Array[{0}]: ", i);
                while((int.TryParse(Console.ReadLine(), out sequenceArray[i])) == false)
                {
                    Console.Write("Error. Enter a number Array[{0}]: ", i);
                }
            }

            int maxLenght, position;

            int[] result = FindSequence(sequenceArray, out maxLenght, out position);

            Console.WriteLine("Longest sequence found of {0} elements ending in position {1}", maxLenght, position);
            foreach (var item in result)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }

        public static int[] FindSequence(int[] array,  out int maxLenghtF, out  int positionF)
        {
            int[] len = new int[array.Length];

            len[0] = 1;
            for (int x = 1; x < array.Length; x++)
            {
                int maxVal = 0;
                for (int prev = 0; prev < x; prev++)
                {
                    if (len[prev] > maxVal)
                    {
                        if (array[prev] < array[x])
                            maxVal = len[prev];
                    }
                }
                len[x] = maxVal == 0 ? 1 : 1 + maxVal;
            }

            int maxLenght = 0;
            int position = -1;
            for (int x = 1; x < len.Length; x++)
            {
                if (len[x] > maxLenght)
                {
                    maxLenght = len[x];
                    position = x;
                }
            }

            //result maximal sequence of increasing elements
            int[] result = new int[maxLenght];
            result[maxLenght - 1] = array[position];
            int xx = position;
            for (int j = maxLenght - 2; j >= 0; j--)
            {
                for (int prev = xx - 1; prev >= 0; prev--)
                {
                    if (len[xx] == 1 + len[prev])
                    {
                        result[j] = array[prev];
                        xx = prev;
                        break;
                    }
                }
            }

            maxLenghtF = maxLenght;
            positionF = position;
            return result;
        }
    }
}
