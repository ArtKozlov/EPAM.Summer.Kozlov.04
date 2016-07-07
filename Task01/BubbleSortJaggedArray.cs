using System;
using System.Linq;

namespace Task01
{
    public static class BubbleSortJaggedArray
    {
        /// <summary>
        /// Sorting jagged massive in order of increasing the amounts of elements rows of the matrix.
        /// </summary>
        /// <param name="array">input array</param>
        /// <returns>Sorted array</returns>
        
        public static int[][] SortAscendingSumOfElems(int[][] array)
        {
            if (array.Length == 0)
            {
                throw new Exception("Array is empty!");
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 1; j < array[j].Length - i; j++)
                {
                    if (array[j-1].Sum() > array[j].Sum())
                    {
                        ReplaceRow(ref array[j-1], ref array[j]);
                    }
                }

            }

            return array;
        }
        /// <summary>
        /// Sorting jagged massive in order of decreasing the amounts of elements rows of the matrix.
        /// </summary>
        /// <param name="array">input array</param>
        /// <returns>Sorted array</returns>
        public static int[][] SortDecreasingSumOfElems(int[][] array)
        {
            if (array.Length == 0)
            {
                throw new Exception("Array is empty!");
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 1; j < array[j].Length - i; j++)
                {
                    if (array[j - 1].Sum() < array[j].Sum())
                    {
                        ReplaceRow(ref array[j - 1], ref array[j]);
                    }
                }

            }

            return array;
        }
        /// <summary>
        /// Sorting jagged massive in order of increasing the maximum rows of elements.
        /// </summary>
        /// <param name="array">input array</param>
        /// <returns>Sorted array</returns>
        public static int[][] SortAscendingMaxOfElems(int[][] array)
        {
            if (array.Length == 0)
            {
                throw new Exception("Array is empty!");
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 1; j < array[j].Length - i; j++)
                {
                    if (array[j - 1].Max() > array[j].Max())
                    {
                        ReplaceRow(ref array[j - 1], ref array[j]);
                    }
                }

            }

            return array;
        }
        /// <summary>
        /// Sorting jagged massive in order of decreasing the maximum rows of elements.
        /// </summary>
        /// <param name="array">input array</param>
        /// <returns>Sorted array</returns>
        public static int[][] SortDecreasingMaxOfElems(int[][] array)
        {
            if (array.Length == 0)
            {
                throw new Exception("Array is empty!");
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 1; j < array[j].Length - i; j++)
                {
                    if (array[j - 1].Max() < array[j].Max())
                    {
                        ReplaceRow(ref array[j - 1], ref array[j]);
                    }
                }

            }

            return array;
        }
        /// <summary>
        /// Sorting jagged massive in order ascending order of minimal elements of matrix rows.
        /// </summary>
        /// <param name="array">input array</param>
        /// <returns>Sorted array</returns>
        public static int[][] SortAscendingMinOfElems(int[][] array)
        {
            if (array.Length == 0)
            {
                throw new Exception("Array is empty!");
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 1; j < array[j].Length - i; j++)
                {
                    if (array[j - 1].Min() > array[j].Min())
                    {
                        ReplaceRow(ref array[j - 1], ref array[j]);
                    }
                }

            }

            return array;
        }
        /// <summary>
        /// Sorting jagged massive in order descending of minimal elements of matrix rows.
        /// </summary>
        /// <param name="array">input array</param>
        /// <returns>Sorted array</returns>
        public static int[][] SortDecreasingMinOfElems(int[][] array)
        {
            if (array.Length == 0)
            {
                throw new Exception("Array is empty!");
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 1; j < array[j].Length - i; j++)
                {
                    if (array[j - 1].Min() < array[j].Min())
                    {
                        ReplaceRow(ref array[j - 1], ref array[j]);
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
        private static void ReplaceRow(ref int[] firstArray, ref int[] secondArray)
        {
            int[] tempArray = firstArray;
            firstArray = secondArray;
            secondArray = tempArray;
        }
    }
}
