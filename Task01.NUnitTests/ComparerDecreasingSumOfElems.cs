
using System.Linq;

namespace Task01
{
    public class ComparerDecreasingSumOfElems : IArrayComparer
    {
        public int Compare(int[] lhs, int[] rhs)
        {
            if (lhs.Sum() < rhs.Sum())
            {
                return 1;
            }
            if (lhs.Sum() == rhs.Sum())
            {
                return 1;
            }
            return -1;
        }
    }
}
