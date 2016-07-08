using System;
using NUnit.Framework;

namespace Task03.NUnitTests
{
    public class DoubleExtentionsTests
    {
        [TestCase(34.8, Result = "100000001000001011001100110011001100110011001100110011001100110")]
        [TestCase(100.95, Result = "100000001011001001111001100110011001100110011001100110011001101")]
        public string ConvertDoubleToBinaryTest(double number)
        {
            return number.GetBinaryRepresentationOfNumber();
        }
    }
}
