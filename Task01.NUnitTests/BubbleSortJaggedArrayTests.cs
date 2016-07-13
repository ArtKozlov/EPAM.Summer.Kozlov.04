using System;
using System.Collections;
using NUnit.Framework;
using static Task01.BubbleSortJaggedArray;

namespace Task01.NUnitTests
{
    public class BubbleSortJaggedArrayTests
    {

        [Test, TestCaseSource(typeof(ProviderOfArray), nameof(ProviderOfArray.CasesForSortAscendingSumOfElems))]
        public void SortAscendingSumOfElemsTest(int[][] array, IArrayCompare comparer, int[][] expectedArray)
        {
            array = Sort(array, comparer);
            CollectionAssert.AreEqual(expectedArray, array); 
        }

        [Test, TestCaseSource(typeof(ProviderOfArray), nameof(ProviderOfArray.CasesForSortDecreasingSumOfElems))]
        public void SortDecreasingSumOfElemsTest(int[][] array, IArrayCompare comparer, int[][] expectedArray)
        {
            expectedArray = Sort(array, comparer);
            CollectionAssert.AreEqual(expectedArray, array);
        }

        [Test, TestCaseSource(typeof(ProviderOfArray), nameof(ProviderOfArray.CasesForSortAscendingMaxOfElems))]
        public void SortAscendingMaxOfElemsTest(int[][] array, IArrayCompare comparer, int[][] expectedArray)
        {
            expectedArray = Sort(array, comparer);
            CollectionAssert.AreEqual(expectedArray, array);
        }

        [Test, TestCaseSource(typeof(ProviderOfArray), nameof(ProviderOfArray.CasesForSortDecreasingMaxOfElems))]
        public void SortDecreasingMaxOfElemsTest(int[][] array, IArrayCompare comparer, int[][] expectedArray)
        {
            expectedArray = Sort(array, comparer);
            CollectionAssert.AreEqual(expectedArray, array);
        }

        [Test, TestCaseSource(typeof(ProviderOfArray), nameof(ProviderOfArray.CasesForSortAscendingMinOfElems))]
        public void SortAscendingMinOfElemsTest(int[][] array, IArrayCompare comparer, int[][] expectedArray)
        {
            expectedArray = Sort(array, comparer);
            CollectionAssert.AreEqual(expectedArray, array);
        }

        [Test, TestCaseSource(typeof(ProviderOfArray), nameof(ProviderOfArray.CasesForSortDecreasingMinOfElems))]
        public void SortDecreasingMinOfElemsTest(int[][] array, IArrayCompare comparer, int[][] expectedArray)
        {
            expectedArray = Sort(array, comparer);
            CollectionAssert.AreEqual(expectedArray, array);
        }
    }

    public class ProviderOfArray
    {
        #region testcases for sum
        public static IEnumerable CasesForSortAscendingSumOfElems
        {
            get
            {
                yield return new TestCaseData(new int[][]
                {
                    new int[] {11, 3, 4, 7, 97},
                    new int[] {0, -22, 41, 65},
                    new int[] {114, 20}
                },
                new CompareAscendingSumOfElems(),
                new int[][]
                {
                    new int[] {0, -22, 41, 65},
                    new int[] {11, 3, 4, 7, 97},
                    new int[] {114, 20}
                });
                yield return new TestCaseData(new int[][]
                {
                    new int[] {11, -33, 54, -78, -97},
                    new int[] {0, -22, 41, 65},
                    new int[] {114, 262}
                },
                new CompareAscendingSumOfElems(),
                new int[][]
                {
                    new int[] {11, -33, 54, -78, -97},
                    new int[] {0, -22, 41, 65},
                    new int[] {114, 262}
                });
                yield return new TestCaseData(new int[][]
                {
                    new int[] {0, 25, 4, 400},
                    new int[] {0, 43, 56, 7, 9},
                    new int[] {114, 622}
                },
                new CompareAscendingSumOfElems(),
                new int[][]
                {
                    new int[] {0, 43, 56, 7, 9},
                    new int[] {0, 25, 4, 400},
                    new int[] {114, 622}
                });
            }

        }

        public static IEnumerable CasesForSortDecreasingSumOfElems
        {
            get
            {
                yield return new TestCaseData(new int[][]
                {
                    new int[] {11, -33, 54, -78, 97},
                    new int[] {0, -22, 41, 65},
                    new int[] {114, -262}
                },
                new CompareDecreasingSumOfElems(),
                new int[][]
                {

                    new int[] {11, 33, 54, -50, 97},
                    new int[] {0, -22, 41, 65},
                    new int[] {114, -262}
                });
                yield return new TestCaseData(new int[][]
                {
                    new int[] {11, -33, 54, -78, 97},
                    new int[] {0, -22, 41, 65},
                    new int[] {114, -262}
                },
                new CompareDecreasingSumOfElems(),
                new int[][]
                {
                    new int[] {0, -22, 41, 65},
                    new int[] {11, -33, 54, -78, 97},
                    new int[] {114, -262}
                });
                yield return new TestCaseData(new int[][]
                {
                    new int[] {0, 43, 56, 7, 9},
                    new int[] {0, 25, 4456, 4566},
                    new int[] {114, 622}
                },
                new CompareDecreasingSumOfElems(),
                new int[][]
                {
                    new int[] {0, 25, 4456, 4566},
                    new int[] {114, 622},
                    new int[] {0, 43, 56, 7, 9}
                });
            }

        }
        #endregion
        #region testcases for Max
        public static IEnumerable CasesForSortAscendingMaxOfElems
        {
            get
            {
                yield return new TestCaseData(new int[][]
                {
                    new int[] {11, -33, 54, -78, 97},
                    new int[] {0, -22, 41, 65},
                    new int[] {114, -262}
                },
                new CompareAscendingMaxOfElems(),
                new int[][]
                {
                    new int[] {0, -22, 41, 65},
                    new int[] {11, -33, 54, -78, 97},
                    new int[] {114, -262}
                });
                yield return new TestCaseData(new int[][]
                {
                    new int[] {11, -33, 54, -78, 97},
                    new int[] {0, -22, 41, 65},
                    new int[] {114, -262}
                },
                new CompareAscendingMaxOfElems(),
                new int[][]
                {
                    new int[] {0, -22, 41, 65},
                    new int[] {11, -33, 54, -78, 97},
                    new int[] {114, -262}
                });
                yield return new TestCaseData(new int[][]
                {
                    new int[] {0, 43, 56, 7, 9},
                    new int[] {0, 25, 4456, 4566},
                    new int[] {114, 622}
                },
                new CompareAscendingMaxOfElems(),
                new int[][]
                {
                    new int[] {0, 43, 56, 7, 9},
                    new int[] {114, 622},
                    new int[] {0, 25, 4456, 4566}
                });
            }

        }

        public static IEnumerable CasesForSortDecreasingMaxOfElems
        {
            get
            {
                yield return new TestCaseData(new int[][]
                {
                    new int[] {11, -33, 54, -78, 97},
                    new int[] {0, -22, 41, 65},
                    new int[] {114, -262}
                },
                new CompareDecreasingMaxOfElems(),
                new int[][]
                {
                    new int[] {114, -262},
                    new int[] {11, -33, 54, -78, 97},
                    new int[] {0, -22, 41, 65}
                });
                yield return new TestCaseData(new int[][]
                {
                    new int[] {11, -33, 54, -78, 97},
                    new int[] {0, -22, 41, 65},
                    new int[] {114, -262}
                },
                new CompareDecreasingMaxOfElems(),
                new int[][]
                {
                    new int[] {114, -262},
                    new int[] {11, -33, 54, -78, 97},
                    new int[] {0, -22, 41, 65}
                });
                yield return new TestCaseData(new int[][]
                {
                    new int[] {0, 43, 56, 7, 9},
                    new int[] {0, 25, 4456, 4566},
                    new int[] {114, 622}
                },
                new CompareDecreasingMaxOfElems(),
                new int[][]
                {
                    new int[] {0, 25, 4456, 4566},
                    new int[] {114, 622},
                    new int[] {0, 43, 56, 7, 9}
                });
            }

        }

        #endregion
        #region testcases for Min
        public static IEnumerable CasesForSortAscendingMinOfElems
        {
            get
            {
                yield return new TestCaseData(new int[][]
                {
                    new int[] {11, 33, 54, -78, 97},
                    new int[] {0, -22, 41, 65},
                    new int[] {114, -262}
                },
                new CompareAscendingMinOfElems(),
                new int[][]
                {
                    new int[] {0, -22, 41, 65},
                    new int[] {11, 33, 54, -78, 97},
                    new int[] {114, -262}
                });
                yield return new TestCaseData(new int[][]
                {
                    new int[] {11, -33, 54, -78, 97},
                    new int[] {0, -22, 41, 65},
                    new int[] {114, -262}
                },
                new CompareAscendingMinOfElems(),
                new int[][]
                {
                    new int[] {0, -22, 41, 65},
                    new int[] {11, -33, 54, -78, 97},
                    new int[] {114, -262}
                });
                yield return new TestCaseData(new int[][]
                {
                    new int[] {0, 43, 56, 7, 9},
                    new int[] {0, 25, 4456, 4566},
                    new int[] {114, 622}
                },
                new CompareAscendingMinOfElems(),
                new int[][]
                {
                    new int[] {0, 43, 56, 7, 9},
                    new int[] {114, 622},
                    new int[] {0, 25, 4456, 4566}
                });
            }

        }

        public static IEnumerable CasesForSortDecreasingMinOfElems
        {
            get
            {
                yield return new TestCaseData(new int[][]
                {
                    new int[] {11, -33, 54, -78, 97},
                    new int[] {0, -22, 41, 65},
                    new int[] {114, -262}
                },
                new CompareDecreasingMinOfElems(),
                new int[][]
                {
                    new int[] {114, -262},
                    new int[] {11, 33, 54, -50, 97},
                    new int[] {0, -22, 41, 65}
                });
                yield return new TestCaseData(new int[][]
                {
                    new int[] {11, -33, 54, -78, 97},
                    new int[] {0, -22, 41, 65},
                    new int[] {114, -262}
                },
                new CompareDecreasingMinOfElems(),
                new int[][]
                {
                    new int[] {114, -262},
                    new int[] {11, -33, 54, -78, 97},
                    new int[] {0, -22, 41, 65}
                });
                yield return new TestCaseData(new int[][]
                {
                    new int[] {0, 43, 56, 7, 9},
                    new int[] {0, 25, 4456, 4566},
                    new int[] {114, 622}
                },
                new CompareDecreasingMinOfElems(),
                new int[][]
                {
                    new int[] {0, 25, 4456, 4566},
                    new int[] {114, 622},
                    new int[] {0, 43, 56, 7, 9}
                });
            }

        }

        #endregion
    }
}
