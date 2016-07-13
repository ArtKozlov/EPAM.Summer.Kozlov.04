using System;
using System.Linq;

namespace Task01
{
    public class CompareAscendingMinOfElems : IArrayCompare
    {
        public bool Compare(int[] lhs, int[] rhs)
        {
            if (lhs.Min() > rhs.Min())
            {
                return true;
            }
            return false;
        }
    }
}
