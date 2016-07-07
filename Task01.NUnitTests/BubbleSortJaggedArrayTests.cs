using System;
using System.Collections;
using NUnit.Framework;
using static Task01.BubbleSortJaggedArray;

namespace Task01.NUnitTests
{
    public class BubbleSortJaggedArrayTests
    {

        [Test, TestCaseSource(typeof(ProviderOfArray), nameof(ProviderOfArray.CasesForSortAscendingSumOfElems))]
        public void SortAscendingSumOfElemsTest(int[][] array, int[][] expectedArray)
        {
            expectedArray = SortAscendingSumOfElems(array);
            CollectionAssert.AreEqual(array, expectedArray); 
        }

        [Test, TestCaseSource(typeof(ProviderOfArray), nameof(ProviderOfArray.CasesForSortDecreasingSumOfElems))]
        public void SortDecreasingSumOfElemsTest(int[][] array, int[][] expectedArray)
        {
            expectedArray =SortDecreasingSumOfElems(array);
            CollectionAssert.AreEqual(array, expectedArray);
        }

        [Test, TestCaseSource(typeof(ProviderOfArray), nameof(ProviderOfArray.CasesForSortAscendingMaxOfElems))]
        public void SortAscendingMaxOfElemsTest(int[][] array, int[][] expectedArray)
        {
            expectedArray = SortAscendingMaxOfElems(array);
            CollectionAssert.AreEqual(array, expectedArray);
        }

        [Test, TestCaseSource(typeof(ProviderOfArray), nameof(ProviderOfArray.CasesForSortDecreasingMaxOfElems))]
        public void SortDecreasingMaxOfElemsTest(int[][] array, int[][] expectedArray)
        {
            expectedArray = SortDecreasingMaxOfElems(array);
            CollectionAssert.AreEqual(array, expectedArray);
        }

        [Test, TestCaseSource(typeof(ProviderOfArray), nameof(ProviderOfArray.CasesForSortAscendingMinOfElems))]
        public void SortAscendingMinOfElemsTest(int[][] array, int[][] expectedArray)
        {
            expectedArray = SortAscendingMinOfElems(array);
            CollectionAssert.AreEqual(array, expectedArray);
        }

        [Test, TestCaseSource(typeof(ProviderOfArray), nameof(ProviderOfArray.CasesForSortDecreasingMinOfElems))]
        public void SortDecreasingMinOfElemsTest(int[][] array, int[][] expectedArray)
        {
            expectedArray = SortDecreasingMinOfElems(array);
            CollectionAssert.AreEqual(array, expectedArray);
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
                    new int[] {11, 33, 54, 78, 97},
                    new int[] {0, -22, 41, 65},
                    new int[] {114, -262}
                },
                new int[][]
                {
                    new int[] {114, -262},
                    new int[] {0, -22, 41, 65},
                    new int[] {11, 33, 54, 78, 97}
                });
                yield return new TestCaseData(new int[][]
                {
                    new int[] {11, -33, 54, -78, 97},
                    new int[] {0, -22, 41, 65},
                    new int[] {114, -262}
                },
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
                new int[][]
                {
                    new int[] {0, 43, 56, 7, 9},
                    new int[] {114, 622},
                    new int[] {0, 25, 4456, 4566}
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
