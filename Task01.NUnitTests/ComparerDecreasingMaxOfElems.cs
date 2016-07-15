using System;
using System.Linq;

namespace Task01
{
    public class ComparerDecreasingMaxOfElems : IArrayComparer
    {
        public int Compare(int[] lhs, int[] rhs)
        {
            if (lhs.Max() < rhs.Max())
            {
                return 1;
            }
            if (lhs.Max() == rhs.Max())
            {
                return 0;
            }
            return -1;
        }
    }
}
