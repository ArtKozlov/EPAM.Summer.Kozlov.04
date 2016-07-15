using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using static Task01.SortJaggedArrayWithDelegate;

namespace Task01.NUnitTests
{
    class SortJaggedArrayWithDelegateTests
    {

        [Test, TestCaseSource(typeof(ProviderArrayForSortWithDelegate), nameof(ProviderArrayForSortWithDelegate.CasesForSortAscendingSumOfElems))]
        public void SortAscendingSumOfElemsTest(int[][] array, Func<int[],int[],int> comparerFunc, int[][] expectedArray)
        {
            array = Sort(array, comparerFunc);
            CollectionAssert.AreEqual(expectedArray, array);
        }

        [Test, TestCaseSource(typeof(ProviderArrayForSortWithDelegate), nameof(ProviderArrayForSortWithDelegate.CasesForSortDecreasingSumOfElems))]
        public void SortDecreasingSumOfElemsTest(int[][] array, Func<int[], int[], int> comparerFunc, int[][] expectedArray)
        {
            expectedArray = Sort(array, comparerFunc);
            CollectionAssert.AreEqual(expectedArray, array);
        }

        [Test, TestCaseSource(typeof(ProviderArrayForSortWithDelegate), nameof(ProviderArrayForSortWithDelegate.CasesForSortAscendingMaxOfElems))]
        public void SortAscendingMaxOfElemsTest(int[][] array, Func<int[], int[], int> comparerFunc, int[][] expectedArray)
        {
            expectedArray = Sort(array, comparerFunc);
            CollectionAssert.AreEqual(expectedArray, array);
        }

        [Test, TestCaseSource(typeof(ProviderArrayForSortWithDelegate), nameof(ProviderArrayForSortWithDelegate.CasesForSortDecreasingMaxOfElems))]
        public void SortDecreasingMaxOfElemsTest(int[][] array, Func<int[], int[], int> comparerFunc, int[][] expectedArray)
        {
            expectedArray = Sort(array, comparerFunc);
            CollectionAssert.AreEqual(expectedArray, array);
        }

        [Test, TestCaseSource(typeof(ProviderArrayForSortWithDelegate), nameof(ProviderArrayForSortWithDelegate.CasesForSortAscendingMinOfElems))]
        public void SortAscendingMinOfElemsTest(int[][] array, Func<int[], int[], int> comparerFunc, int[][] expectedArray)
        {
            expectedArray = Sort(array, comparerFunc);
            CollectionAssert.AreEqual(expectedArray, array);
        }

        [Test, TestCaseSource(typeof(ProviderArrayForSortWithDelegate), nameof(ProviderArrayForSortWithDelegate.CasesForSortDecreasingMinOfElems))]
        public void SortDecreasingMinOfElemsTest(int[][] array, Func<int[], int[], int> comparerFunc, int[][] expectedArray)
        {
            expectedArray = Sort(array, comparerFunc);
            CollectionAssert.AreEqual(expectedArray, array);
        }
    }

    public class ProviderArrayForSortWithDelegate
    {
        static Func<int[], int[], int> comparerAscendingSumOfElems = new ComparerAscendingSumOfElems().Compare;
        static Func<int[], int[], int> comparerDecreasingSumOfElems = new ComparerDecreasingSumOfElems().Compare;
        static Func<int[], int[], int> comparerAscendingMaxOfElems = new ComparerAscendingMaxOfElems().Compare;
        static Func<int[], int[], int> comparerDecreasingMaxOfElems = new ComparerDecreasingMaxOfElems().Compare;
        static Func<int[], int[], int> comparerAscendingMinOfElems = new ComparerAscendingMinOfElems().Compare;
        static Func<int[], int[], int> comparerDecreasingMinOfElems = new ComparerDecreasingMinOfElems().Compare;
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
                comparerAscendingSumOfElems,
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
                comparerAscendingSumOfElems,
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
                comparerAscendingSumOfElems,
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
                comparerDecreasingSumOfElems,
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
                comparerDecreasingSumOfElems,
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
                comparerDecreasingSumOfElems,
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
                comparerAscendingMaxOfElems,
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
                comparerAscendingMaxOfElems,
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
                comparerAscendingMaxOfElems,
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
                comparerDecreasingMaxOfElems,
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
                comparerDecreasingMaxOfElems,
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
                comparerDecreasingMaxOfElems,
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
                comparerAscendingMinOfElems,
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
                comparerAscendingMinOfElems,
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
                comparerAscendingMinOfElems,
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
                comparerDecreasingMinOfElems,
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
                comparerDecreasingMinOfElems,
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
                comparerDecreasingMinOfElems,
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
