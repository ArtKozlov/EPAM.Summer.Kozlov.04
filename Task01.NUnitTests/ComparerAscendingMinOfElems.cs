using System;
using System.Linq;

namespace Task01
{
    public class ComparerAscendingMinOfElems : IArrayComparer
    {
        public int Compare(int[] lhs, int[] rhs)
        {
            if (lhs.Min() > rhs.Min())
            {
                return 1;
            }
            if (lhs.Min() == rhs.Min())
            {
                return 0;
            }
            return -1;
        }
    }
}
