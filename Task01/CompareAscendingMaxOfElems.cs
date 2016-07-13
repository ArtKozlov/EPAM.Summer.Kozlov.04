using System;
using System.Linq;

namespace Task01
{
    public class CompareAscendingMaxOfElems : IArrayCompare
    {
        public bool Compare(int[] lhs, int[] rhs)
        {
            if (lhs.Max() > rhs.Max())
            {
                return true;
            }
            return false;
        }
    }
}
