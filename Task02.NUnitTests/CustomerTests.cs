using System;
using System.Globalization;
using NUnit.Framework;

namespace Task02.NUnitTests
{
    public class CustomerTests
    {
        [TestCase("artyom", 1000, "+375(44)1111111","N", Result = "Customer record: artyom")]
        [TestCase("artyom", 1000, "+375(44)1111111", "Ph", Result = "Customer record: +375(44)1111111")]
        [TestCase("artyom", 1000, "+375(44)1111111", "R", Result = "Customer record: 1000")]
        [TestCase("artyom", 1000, "+375(44)1111111", "NPh", Result = "Customer record: artyom, +375(44)1111111")]
        [TestCase("artyom", 1000, "+375(44)1111111", "PhR", Result = "Customer record: +375(44)1111111, 1000")]
        [TestCase("artyom", 1000, "+375(44)1111111", "NR", Result = "Customer record: artyom, 1000")]
        [TestCase("artyom", 1000, "+375(44)1111111", "NPhR", Result = "Customer record: artyom, +375(44)1111111, 1000")]
        public string PositiveTestGetCustomerInfo(string name, decimal revanue, string contactPhone, string format)
        {
            Customer client = new Customer(name, revanue, contactPhone);
            return client.ToString(format, new FormatProvider());
        }

        [TestCase("artyom", 1000, "+375(44)1111111", "Re")]
        public void InputBadFormatForGetCustomerInfo(string name, decimal revanue, string contactPhone, string format)
        {
            Customer client = new Customer(name, revanue, contactPhone);
            Assert.Throws<FormatException>(() => client.ToString(format, new FormatProvider()));
        }
        [TestCase("artyom", 1000, "+375(44)1111111", null)]
        public void InputArgumentNullForGetCustomerInfo(string name, decimal revanue, string contactPhone, string format)
        {
            Customer client = new Customer(name, revanue, contactPhone);
            Assert.Throws<ArgumentNullException>(() => client.ToString(format, new FormatProvider()));
        }
    }
}
