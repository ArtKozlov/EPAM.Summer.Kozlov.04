using System;
using System.Linq;

namespace Task01
{
    public class ComparerAscendingSumOfElems : IArrayComparer
    {
        public bool Compare(int[] lhs, int[] rhs)
        {
            if (lhs.Sum() > rhs.Sum())
            {
                return true;
            }
            return false;
        }
    }
}
