using System;
using System.Collections;
using System.Linq;

namespace Task01
{
    public static class BubbleSortJaggedArray
    {
        /// <summary>
        /// Sorting jagged massive in order of increasing the amounts of elements rows of the matrix.
        /// </summary>
        /// <param name="array">input jagged array</param>
        /// <param name="comparer">It takes an object implements an interface IArrayCompare</param>
        /// <returns>Sorted array</returns>
        public static int[][] Sort(int[][] array, IArrayComparer comparer)
        {
            if (ReferenceEquals(null, array) || ReferenceEquals(null, comparer))
                throw new ArgumentNullException();
            if (array.Length == 0)
                throw new ArgumentException("Array is empty!");

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 1; j < array[j].Length - i; j++)
                {
                    if (comparer.Compare(array[j-1], array[j]))
                    {
                        Swap(ref array[j-1], ref array[j]);
                    }
                }

            }

            return array;
        }

        /// <summary>
        /// Replace rows two massive.
        /// </summary>
        /// <param name="firstArray">first array</param>
        /// <param name="secondArray">second array</param>
        private static void Swap(ref int[] firstArray, ref int[] secondArray)
        {
            int[] tempArray = firstArray;
            firstArray = secondArray;
            secondArray = tempArray;
        }
    }
}
