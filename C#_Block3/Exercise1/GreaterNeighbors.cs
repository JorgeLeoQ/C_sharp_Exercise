using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class GreaterNeighbors
    {
        public static bool GreaterThanNeighbors(int[] array, int position)
        {
          
            if(position == array.Length)
            {
                if (array[position] > array[position - 1])
                {
                    return true;
                }
            }
            else if(array.Length == 1)
            {
                return true;
            }
            else if(position == 0)
            {
                if(array[position] > array[position + 1])
                {
                    return true;
                }
            }
            else if((array[position] > array[position - 1]) && (array[position] > array[position + 1]))
            {
                return true;
            }

            return false;
        }

        public static int FindFirstGreaterThatNeighbor(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                if(GreaterThanNeighbors(array, i) == true)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
