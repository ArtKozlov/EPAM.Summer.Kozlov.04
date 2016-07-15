using System;
using System.Linq;

namespace Task01
{
    public class ComparerDecreasingMinOfElems : IArrayComparer
    {
        public bool Compare(int[] lhs, int[] rhs)
        {
            if (lhs.Min() < rhs.Min())
            {
                return true;
            }
            return false;
        }
    }
}
