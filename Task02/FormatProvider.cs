using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    public class FormatProvider: IFormatProvider
    {
        public object GetFormat(Type formatType)
        {
            if (formatType == typeof(ICustomFormatter))
                return this;
            return null;
        }

    }
}
