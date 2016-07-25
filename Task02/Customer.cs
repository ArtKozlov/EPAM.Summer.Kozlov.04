using System;
using System.Text;

namespace Task02
{
    public class Customer : IFormattable
    {
        /// <summary>
        /// This object have name, revenue, phone and used to provide this information.
        /// </summary>
        /// <param name="name">name of customer</param>
        /// <param name="revenue">revenue of customer</param>
        /// <param name="contactPhone">Phone of customer</param>
        public Customer(string name, decimal revenue, string contactPhone)
        {
            Name = name;
            Revenue = revenue;
            ContactPhone = contactPhone;
        }

        public string Name { get; }

        public decimal Revenue { get; }

        public string ContactPhone { get; }

        /// <summary>
        /// The method converts the string value to information on the subject in the right format.
        /// </summary>
        /// <param name="format">formatting type</param>
        /// <returns>Information about the object in the right format.</returns>
        public string ToString(string format, IFormatProvider formatProvider)
        {
            if (format == null)
            {
                throw new ArgumentNullException();
            }
            string answer = "Customer record: ";
            switch (format)
            {
                case "Ph":
                    return answer + ContactPhone;
                case "R":
                    return answer + Revenue;
                case "N":
                    return answer + Name;
                case "NPhR":
                    return answer + Name + ", " + ContactPhone + ", " + Revenue;
                case "NPh":
                    return answer + Name + ", " + ContactPhone;
                case "NR":
                    return answer + Name + ", " + Revenue;
                case "PhR":
                    return answer + ContactPhone + ", " + Revenue;
                default:
                    throw new FormatException(String.Format("The '{0}' format string is not supported.", format));
            }

        }

        /// <summary>
        /// Representation of customer in string with NPhR format.
        /// </summary>
        /// <returns>Concatination of customer properties.</returns>
        public override string ToString()
        {
            return ToString("NPhR", null);
        }
    }
}
