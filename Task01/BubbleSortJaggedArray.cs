using System;
using System.Linq;

namespace Task01
{
    public static class BubbleSortJaggedArray
    {
        public static int[][] SortAscendingSumOfElems(int[][] array)
        {
            if (array.Length == 0)
            {
                throw new Exception("Array is empty!");
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array[j].Length - i - 1; j++)
                {
                    if (array[j].Sum() > array[j + 1].Sum())
                    {
                        ReplaceRow(ref array[j], ref array[j+1]);
                    }
                }

            }

            return array;
        }

        public static int[][] SortDecreasingSumOfElems(int[][] array)
        {
            if (array.Length == 0)
            {
                throw new Exception("Array is empty!");
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array[j].Length - i - 1; j++)
                {
                    if (array[j].Sum() < array[j + 1].Sum())
                    {
                        ReplaceRow(ref array[j], ref array[j + 1]);
                    }
                }

            }

            return array;
        }

        public static int[][] SortAscendingMaxOfElems(int[][] array)
        {
            if (array.Length == 0)
            {
                throw new Exception("Array is empty!");
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array[j].Length - i - 1; j++)
                {
                    if (array[j].Max() > array[j + 1].Max())
                    {
                        ReplaceRow(ref array[j], ref array[j + 1]);
                    }
                }

            }

            return array;
        }

        public static int[][] SortDecreasingMaxOfElems(int[][] array)
        {
            if (array.Length == 0)
            {
                throw new Exception("Array is empty!");
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array[j].Length - i - 1; j++)
                {
                    if (array[j].Max() < array[j + 1].Max())
                    {
                        ReplaceRow(ref array[j], ref array[j + 1]);
                    }
                }

            }

            return array;
        }

        public static int[][] SortAscendingMinOfElems(int[][] array)
        {
            if (array.Length == 0)
            {
                throw new Exception("Array is empty!");
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array[j].Length - i - 1; j++)
                {
                    if (array[j].Min() > array[j + 1].Min())
                    {
                        ReplaceRow(ref array[j], ref array[j + 1]);
                    }
                }

            }

            return array;
        }

        public static int[][] SortDecreasingMinOfElems(int[][] array)
        {
            if (array.Length == 0)
            {
                throw new Exception("Array is empty!");
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array[j].Length - i - 1; j++)
                {
                    if (array[j].Min() < array[j + 1].Min())
                    {
                        ReplaceRow(ref array[j], ref array[j + 1]);
                    }
                }

            }

            return array;
        }

        public static void ReplaceRow(ref int[] firstArray, ref int[] secondArray)
        {
            int[] tempArray = firstArray;
            firstArray = secondArray;
            secondArray = tempArray;
        }
    }
}
