using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standards.Sort
{
    public class SortExample
    {

        public int[] GetRandomArray(int min, int max, int size)
        {
            var random = new Random();
            return Enumerable.Repeat(0, size).Select(i => random.Next(min, max)).ToArray();
        }

        /// <summary>
        /// O(n2) - good sorting choice for when data is nearly sorted or when the size is small.
        /// O(1) space
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public int[] InsertionSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    //if the previous item is bigger than the next
                    if (array[j - 1] > array[j])
                    {
                        //swap them around

                        //get the higher value
                        int higher = array[j - 1];
                        //set the higher value array position to the lower value (swap)
                        array[j - 1] = array[j];
                        //now do the second part of the swap, set the lower value array position to the higher amount
                        array[j] = higher;
                    }
                }
            }            

            return array;
        }
    }
}
