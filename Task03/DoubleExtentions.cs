using System;

namespace Task03
{
    public static class DoubleExtentions
    {
        /// <summary>
        /// The method converts the double value to binary value.
        /// </summary>
        /// <param name="number">input number</param>
        /// <returns>string binary number</returns>
        public static string GetBinaryRepresentationOfNumber(this Double number)
        {
            long currentNumber = BitConverter.DoubleToInt64Bits(number);
            string result = Convert.ToString(Convert.ToInt64(currentNumber.ToString()), 2);
            // can do in any number system, changing the argument 2 to 8,10,16.
            return result;
            // I can try to do a return value is long, but it's so large.
        }
    }
}
