using System;
using System.Collections;
using NUnit.Framework;
using static Task01.BubbleSortJaggedArray;

namespace Task01.NUnitTests
{
    public class BubbleSortJaggedArrayTests
    {

        [Test, TestCaseSource(typeof(ProviderOfArray), nameof(ProviderOfArray.CasesForSortAscendingSumOfElems))]
        public void SortAscendingSumOfElemsTest(int[][] array, IArrayComparer comparer, int[][] expectedArray)
        {
            array = Sort(array, comparer);
            CollectionAssert.AreEqual(expectedArray, array); 
        }

        [Test, TestCaseSource(typeof(ProviderOfArray), nameof(ProviderOfArray.CasesForSortDecreasingSumOfElems))]
        public void SortDecreasingSumOfElemsTest(int[][] array, IArrayComparer comparer, int[][] expectedArray)
        {
            expectedArray = Sort(array, comparer);
            CollectionAssert.AreEqual(expectedArray, array);
        }

        [Test, TestCaseSource(typeof(ProviderOfArray), nameof(ProviderOfArray.CasesForSortAscendingMaxOfElems))]
        public void SortAscendingMaxOfElemsTest(int[][] array, IArrayComparer comparer, int[][] expectedArray)
        {
            expectedArray = Sort(array, comparer);
            CollectionAssert.AreEqual(expectedArray, array);
        }

        [Test, TestCaseSource(typeof(ProviderOfArray), nameof(ProviderOfArray.CasesForSortDecreasingMaxOfElems))]
        public void SortDecreasingMaxOfElemsTest(int[][] array, IArrayComparer comparer, int[][] expectedArray)
        {
            expectedArray = Sort(array, comparer);
            CollectionAssert.AreEqual(expectedArray, array);
        }

        [Test, TestCaseSource(typeof(ProviderOfArray), nameof(ProviderOfArray.CasesForSortAscendingMinOfElems))]
        public void SortAscendingMinOfElemsTest(int[][] array, IArrayComparer comparer, int[][] expectedArray)
        {
            expectedArray = Sort(array, comparer);
            CollectionAssert.AreEqual(expectedArray, array);
        }

        [Test, TestCaseSource(typeof(ProviderOfArray), nameof(ProviderOfArray.CasesForSortDecreasingMinOfElems))]
        public void SortDecreasingMinOfElemsTest(int[][] array, IArrayComparer comparer, int[][] expectedArray)
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
                new ComparerAscendingSumOfElems(),
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
                new ComparerAscendingSumOfElems(),
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
                new ComparerAscendingSumOfElems(),
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
                new ComparerDecreasingSumOfElems(),
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
                new ComparerDecreasingSumOfElems(),
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
                new ComparerDecreasingSumOfElems(),
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
                new ComparerAscendingMaxOfElems(),
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
                new ComparerAscendingMaxOfElems(),
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
                new ComparerAscendingMaxOfElems(),
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
                new ComparerDecreasingMaxOfElems(),
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
                new ComparerDecreasingMaxOfElems(),
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
                new ComparerDecreasingMaxOfElems(),
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
                new ComparerAscendingMinOfElems(),
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
                new ComparerAscendingMinOfElems(),
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
                new ComparerAscendingMinOfElems(),
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
                new ComparerDecreasingMinOfElems(),
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
                new ComparerDecreasingMinOfElems(),
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
                new ComparerDecreasingMinOfElems(),
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
